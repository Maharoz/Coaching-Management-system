using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Byatikram.Properties;
using Microsoft.Win32;

namespace Byatikram
{
    public partial class FeeCollection : Form
    {
        int durAfterThisPay = 0;
        int totalPayable;
        int amountPayable;
        string studentMobileNumber;
        DateTime creationDate;
        IList<Class1> items;
        int totalPayableOlder;
        int totalDueOlder;
        public FeeCollection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int isFeeOfMonthDuplicate = 0;
            SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            SqlCommand cmd;
            SqlCommand dmd;
            SqlDataAdapter adapt;

            string rollNo = StudentRollTextBox.Text;
            string name = bunifuDropdown1.selectedValue + ',' + bunifuDropdown2.selectedValue;
            string trxID = rollNo + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() +
                           DateTime.Today.Year.ToString();

            foreach (var item in items)
            {
                if (item.MonthName == bunifuDropdown1.selectedValue + ',' + bunifuDropdown2.selectedValue)
                {
                    isFeeOfMonthDuplicate = isFeeOfMonthDuplicate +1;
                    
                }
            }

            int month = DateTime.ParseExact(bunifuDropdown1.selectedValue, "MMMM", CultureInfo.CurrentCulture).Month;


            DateTime collectionMonth = new DateTime(Convert.ToInt32(bunifuDropdown2.selectedValue),month,1);
            if (collectionMonth < creationDate.Date)
            {
                MessageBox.Show("Fees for the month information is wrong");
            }
            else if (isFeeOfMonthDuplicate >0)
            {
                MessageBox.Show("A transaction for selected month for this student is already exists");
            }
            else
            {
                dmd = new SqlCommand(@"update StudentDue set TotalDue= @TotalDue where RollNumber=@StudentRollNumber", con);
                cmd = new SqlCommand("insert into MoneyCollection(StudentRollNumber,CollectedAmount,CollectorID,CollectionMonth,StudentName,CollectionDate,CollectionType,OtherDiscount,TrxID) values(@StudentRollNumber,@CollectedAmount,@CollectorID,@CollectionMonth,@StudentName,@CollectionDate,@CollectionType,@OtherDiscount,@TrxID)", con);
                con.Open();
                int totalDue;
                if (int.TryParse(TotalDue.Text, out totalDue))
                {
                    dmd.Parameters.AddWithValue("@TotalDue", totalDue);
                }

                int rollNumber;
                if (int.TryParse(StudentRollTextBox.Text, out rollNumber))
                {
                    cmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                    dmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                }
                cmd.Parameters.AddWithValue("@CollectedAmount", AmountTextBox.Text);
                cmd.Parameters.AddWithValue("@StudentName", StudentNameTextBox.Text);
                cmd.Parameters.AddWithValue("@CollectionMonth", bunifuDropdown1.selectedValue + ',' + bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@CollectorID", Users.UserID);
                cmd.Parameters.AddWithValue("@CollectionDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@OtherDiscount", OtherDiscountTextBox.Text);
                cmd.Parameters.AddWithValue("@CollectionType", "MonthlyFee");
                cmd.Parameters.AddWithValue("@TrxID", trxID);

                cmd.ExecuteNonQuery();
                dmd.ExecuteNonQuery();
                con.Close();
               SendSMS(StudentRollTextBox.Text, AmountTextBox.Text, trxID,StudentNameTextBox.Text);
                MessageBox.Show("Record Inserted Successfully");



                FeeCollection NewForm = new FeeCollection();
                NewForm.Show();
                this.Dispose(false);

                string collectionType = "MonthlyFee";
                PrintableForm objFrmMain = new PrintableForm(rollNo, name, collectionType);
                objFrmMain.Show();

            }
            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masterForm objFrmMain = new masterForm();
            this.Hide();
            objFrmMain.Show();
        }

        private void SendSMS(string rollNumber,string amount , string trxID,string studentName)
        {
            string result = "";
            WebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                //01711789090
                String to = "01711789090," + studentMobileNumber; //Recipient Phone Number multiple number must be separated by comma
                String token = "a201640750cff06a9171f13db8412ec1"; //generate token from the control panel
                String message = System.Uri.EscapeUriString("'Byatikram Academic Care'" +
                                                            " Money Received " + amount +
                                                            "Tk.from " + studentName
                                                            + " roll number " + rollNumber
                                                            + " .Transaction id " + trxID
                                                            + " For Query:Call 01971789090"); //do not use single quotation (') in the message to avoid forbidden result
                String url = "http://api.greenweb.com.bd/api.php?token=" + token + "&to=" + to + "&message=" + message;
                request = WebRequest.Create(url);

                // Send the 'HttpWebRequest' and wait for response.
                response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader reader = new
                    System.IO.StreamReader(stream, ec);
                result = reader.ReadToEnd();
                Console.WriteLine(result);
                reader.Close();
                stream.Close();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

        }

        private void StudentRollTextBox_OnValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            SqlCommand cmd;
            SqlDataAdapter adapt;

            SqlDataAdapter adptt;

            SqlDataAdapter adpttt;

            int rollNumber;
            int.TryParse(StudentRollTextBox.Text, out rollNumber);
            DataTable td = new DataTable();
            adapt = new SqlDataAdapter(@"SELECT  r.StudentName,d.TotalDue ,r.MonthlyFee,r.MobileNumber,r.CreationDate
            FROM Registration r INNER JOIN StudentDue d
                ON r.StudentRollNumber = d.RollNumber
            where  r.StudentRollNumber = " + rollNumber , con);

            DataTable tf = new DataTable();
            string sqlText = "SELECT  CollectionMonth FROM MoneyCollection where StudentRollNumber = " + rollNumber;
            adpttt = new SqlDataAdapter(@"SELECT  CollectionMonth
            FROM MoneyCollection
            where StudentRollNumber = " + rollNumber, con);


            //int referenceRollNumber;
            //int.TryParse(ReferenceRollNumber.Text, out referenceRollNumber);
            DataTable tl = new DataTable();
            string sql = "SELECT  r.StudentRollNumber FROM Registration r where r.RefrenceRollNumber = " + rollNumber;
            adptt = new SqlDataAdapter(@"SELECT  r.StudentRollNumber
            FROM Registration r 
            where  r.RefrenceRollNumber = " + rollNumber, con);


            con.Open();

            adpttt.Fill(tf);
            adapt.Fill(td);
            adptt.Fill(tl);
            con.Close();

            if (tf.Rows.Count > 0)
            {
                 items = tf.AsEnumerable().Select(row =>
                    new Class1
                    {
                        MonthName = row.Field<string>("CollectionMonth")
                    }).ToList();
            }

            if (td.Rows.Count > 0)
            {
                int amountTextBox;
                int totalDue;
                StudentNameTextBox.Text = td.Rows[0].ItemArray[0].ToString();
                DueTextBox.Text = td.Rows[0].ItemArray[1].ToString();
                TotalDue.Text = td.Rows[0].ItemArray[1].ToString();
                AmountTextBox.Text = td.Rows[0].ItemArray[2].ToString();
                studentMobileNumber = td.Rows[0].ItemArray[3].ToString();
                creationDate = (DateTime)td.Rows[0].ItemArray[4];

                int.TryParse(AmountTextBox.Text, out amountTextBox);
                int.TryParse(TotalDue.Text, out totalDue);
                int payable = amountTextBox + totalDue;
                totalPayableOlder = amountTextBox + totalDue;
                totalDueOlder = totalDue;
                TotalPayable.Text = payable.ToString();


            }
            else
            {
                StudentNameTextBox.Text = string.Empty;
                DueTextBox.Text = string.Empty;
                TotalDue.Text = string.Empty;
                AmountTextBox.Text = string.Empty;
                TotalPayable.Text = string.Empty;
                ReferalDiscountTextBox.Text = string.Empty;
                ReferenceRollNumber.Text = string.Empty;

            }

            if (tl.Rows.Count > 0)
            {
                string refRoll=string.Empty;
                for (int i=0;i < tl.Rows.Count;i++)
                {
                    refRoll = refRoll+ "," + tl.Rows[i].ItemArray[0].ToString();
                    
                }

                int refDiscount = 500 * tl.Rows.Count;
                ReferalDiscountTextBox.Text = refDiscount.ToString();
                refRoll = refRoll.Trim().TrimStart(',');
                ReferenceRollNumber.Text = refRoll.ToString();
            }
            else
            {
                ReferalDiscountTextBox.Text = string.Empty;
                ReferenceRollNumber.Text = string.Empty;
                //TotalPayable.Text = string.Empty;
                //TotalDue.Text = string.Empty;
            }
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DueForThisPay_OnValueChanged(object sender, EventArgs e)
        {
            int.TryParse(TotalPayable.Text, out totalPayable);
            int.TryParse(AmountPaid.Text, out amountPayable);
            
            durAfterThisPay = totalPayable - amountPayable;
            TotalDue.Text = durAfterThisPay.ToString();


        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            
            int amountPayableNew;
            int totalDueNew;
            int otherDiscount;
            int.TryParse(OtherDiscountTextBox.Text, out otherDiscount);

            amountPayableNew = totalPayableOlder - otherDiscount;
            TotalPayable.Text = amountPayableNew.ToString();
            totalDueNew = totalDueOlder - otherDiscount;
            TotalDue.Text = totalDueNew.ToString();


           
        }

        private void ReferalDiscountTextBox_OnValueChanged(object sender, EventArgs e)
        {
            int amountPayableNew;
            int totalDueNew;
            int referalDiscount;
            int.TryParse(ReferalDiscountTextBox.Text, out referalDiscount);

            amountPayableNew = totalPayableOlder - referalDiscount;
            TotalPayable.Text = amountPayableNew.ToString();
            totalDueNew = totalDueOlder - referalDiscount;
            TotalDue.Text = totalDueNew.ToString();

        }
    }
}
