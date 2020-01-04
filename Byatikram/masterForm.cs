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

namespace Byatikram
{
    public partial class masterForm : Form
    {
        int monthlyFee;
        int AdmissionFee;
        private int payable=0;
        private int payableForDue = 0;
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "ByatikramDB.mdf";
      //  SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
        SqlCommand cmd;
        SqlCommand dmd;
        SqlCommand fmd;
        SqlCommand gmd;
        SqlCommand pmd;
        SqlDataAdapter adapt;
        public masterForm()
        {
            InitializeComponent();
        
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int paidAmountDuringAddmissionForCheck;
            int.TryParse(PaidAmountTextbox.Text, out paidAmountDuringAddmissionForCheck);

            int addmissionFeeForCheck;
            int.TryParse(AdmissionFeeDropdown.selectedValue, out addmissionFeeForCheck);

            int rollNumberForDuplicacy;
            int.TryParse(RollNumberTextBox.Text, out rollNumberForDuplicacy);
            SqlConnection sqlcon = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");

            string query = "Select * from Registration Where StudentRollNumber=" + rollNumberForDuplicacy ;

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("This RollNumber is duplicate");
            }
            else if (addmissionFeeForCheck>paidAmountDuringAddmissionForCheck)
            {
                MessageBox.Show("You have to pay full admission fee for Registration");
            }
            else
            {
                //if(AdmissionFeeDropdown.selectedValue<TotalPaybleTextbox.Text)
            if (RollNumberTextBox.Text != "" && studentNameTextBox.Text != "")
            {
                cmd = new SqlCommand("insert into Registration(StudentName,StudentRollNumber," +
                                     "GuardiansName,Address,DoB,School,Class,AdmissionFee," +
                                     "MobileNumber,Version,Course,MonthlyFee,CourseStartDate,Status," +
                                     "CreationDate,CreatedBy,RefrenceRollNumber," +
                                     "Discount,TotalPayableDuringAdmission," +
                                     "PaidAmountDuringAdmission) " +
                                     "values(@StudentName," +
                                     "@StudentRollNumber,@GuardiansName,@Address,@DoB,@School," +
                                     "@Class,@AdmissionFee,@MobileNumber,@Version" +
                                     ",@Course,@MonthlyFee,@CourseStartDate,@Status,@CreationDate," +
                                     "@CreatedBy,@RefrenceRollNumber,@Discount," +
                                     "@TotalPayableDuringAdmission,@PaidAmountDuringAdmission)", con);

                dmd = new SqlCommand(@"insert into StudentDue(RollNumber,TotalDue) values (@RollNumber,@TotalDue)", con);
                fmd = new SqlCommand(@"insert into Reference(ReferenceRollNumber,ReferedFor,DiscountAmount) values (@ReferenceRollNumber,@ReferedFor,@DiscountAmount)", con);
                gmd = new SqlCommand(@"insert into MoneyCollection(StudentRollNumber,
                                               CollectedAmount,CollectorID,CollectionMonth,
                                            StudentName,CollectionDate,CollectionType,OtherDiscount,TrxID) values(@StudentRollNumber,@CollectedAmount,@CollectorID,
                                            @CollectionMonth,@StudentName,@CollectionDate,@CollectionType,@OtherDiscount,@TrxID)", con);

                pmd = new SqlCommand(@"insert into MoneyCollection(StudentRollNumber,
                                               CollectedAmount,CollectorID,CollectionMonth,
                                            StudentName,CollectionDate,CollectionType,OtherDiscount,TrxID) values(@StudentRollNumber,@CollectedAmount,@CollectorID,
                                            @CollectionMonth,@StudentName,@CollectionDate,@CollectionType,@OtherDiscount,@TrxID)", con);
                    con.Open();
                cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                
                int rollNumber;
                if (int.TryParse(RollNumberTextBox.Text, out rollNumber))
                {
                    cmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                    fmd.Parameters.AddWithValue("@ReferedFor", rollNumber);
                    dmd.Parameters.AddWithValue("@RollNumber", rollNumber);

                    int due;
                    int.TryParse(DueTextbox.Text, out due);
                    dmd.Parameters.AddWithValue("@TotalDue", due);
                    cmd.Parameters.AddWithValue("@Discount", due);
                    fmd.Parameters.AddWithValue("@DiscountAmount", 500);
                }

                int totalpayableDuringAddmission;
                int.TryParse(TotalPaybleTextbox.Text, out totalpayableDuringAddmission);

                int paidAmountDuringAddmission;
                int.TryParse(PaidAmountTextbox.Text, out paidAmountDuringAddmission);

                int addmissionFee;
                int.TryParse(AdmissionFeeDropdown.selectedValue, out addmissionFee);
                int monthlyPayable = paidAmountDuringAddmission - addmissionFee;

                cmd.Parameters.AddWithValue("@GuardiansName", GuardiansNameTextbox.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTexbox.Text);
                cmd.Parameters.AddWithValue("@DoB", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@School", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@Class", bunifuDropdown3.selectedValue);
                cmd.Parameters.AddWithValue("@AdmissionFee", AdmissionFeeDropdown.selectedValue);
                cmd.Parameters.AddWithValue("@MobileNumber", MobileTextBox.Text);
                cmd.Parameters.AddWithValue("@Version", bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@Course", bunifuDropdown4.selectedValue);
                cmd.Parameters.AddWithValue("@MonthlyFee", monthlyFeeDropDown.selectedValue);
                cmd.Parameters.AddWithValue("@CourseStartDate", bunifuDatepicker3.Value);
                cmd.Parameters.AddWithValue("@Status", bunifuDropdown7.selectedValue);
                cmd.Parameters.AddWithValue("@CreationDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@CreatedBy", Users.UserID);
                cmd.Parameters.AddWithValue("@TotalPayableDuringAdmission", totalpayableDuringAddmission);
                cmd.Parameters.AddWithValue("@PaidAmountDuringAdmission", paidAmountDuringAddmission);

                int referenceRollNumber;
                if (int.TryParse(ReferenceRollTextBox.Text, out referenceRollNumber))
                {
                    cmd.Parameters.AddWithValue("@RefrenceRollNumber", referenceRollNumber);
                    fmd.Parameters.AddWithValue("@ReferenceRollNumber", referenceRollNumber);
                    }
                else
                {
                    cmd.Parameters.AddWithValue("@RefrenceRollNumber", referenceRollNumber);
                    fmd.Parameters.AddWithValue("@ReferenceRollNumber", referenceRollNumber);
                }

                string trxID = RollNumberTextBox.Text + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() +
                               DateTime.Today.Year.ToString();

                gmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                gmd.Parameters.AddWithValue("@CollectedAmount", AdmissionFeeDropdown.selectedValue.ToString());
                gmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(bunifuDatepicker3.Value.Month);
                gmd.Parameters.AddWithValue("@CollectionMonth", monthName + ","+ bunifuDatepicker3.Value.Year.ToString());
                gmd.Parameters.AddWithValue("@CollectorID", Users.UserID);
                gmd.Parameters.AddWithValue("@CollectionDate", DateTime.Today);
                gmd.Parameters.AddWithValue("@CollectionType", "Admission");
                gmd.Parameters.AddWithValue("@OtherDiscount", DiscountTextbox.Text); 
                gmd.Parameters.AddWithValue("@TrxID", trxID);



                pmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                pmd.Parameters.AddWithValue("@CollectedAmount", monthlyPayable.ToString());
                pmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
              //  string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(bunifuDatepicker3.Value.Month);
                pmd.Parameters.AddWithValue("@CollectionMonth", monthName + "," + bunifuDatepicker3.Value.Year.ToString());
                pmd.Parameters.AddWithValue("@CollectorID", Users.UserID);
                pmd.Parameters.AddWithValue("@CollectionDate", DateTime.Today);
                pmd.Parameters.AddWithValue("@CollectionType", "MonthlyFee");
                pmd.Parameters.AddWithValue("@OtherDiscount", DiscountTextbox.Text);
                pmd.Parameters.AddWithValue("@TrxID", trxID);



                cmd.ExecuteNonQuery();
                dmd.ExecuteNonQuery();
                fmd.ExecuteNonQuery();
                gmd.ExecuteNonQuery();
                pmd.ExecuteNonQuery();

                    con.Close();
                MessageBox.Show("Record Inserted Successfully");
               
              SendSMS(RollNumberTextBox.Text, paidAmountDuringAddmission.ToString(), trxID,MobileTextBox.Text,studentNameTextBox.Text);
                masterForm NewForm = new masterForm();
                NewForm.Show();
                this.Dispose(false);
                string collectionType = "AdmissionFee";
                string date = monthName + "," + bunifuDatepicker3.Value.Year.ToString();
                 PrintableForm objFrmMain = new PrintableForm(rollNumber.ToString(), date, collectionType);
                objFrmMain.Show();

                }
            else
            {
                MessageBox.Show("Please Provide Required Fields!");
            }
            }
        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FeeCollection objFrmMain = new FeeCollection();
           this.Hide();
            objFrmMain.Show();
        }

        private void bunifuDropdown5_onItemSelected(object sender, EventArgs e)
        {
            payable = 0;
            int.TryParse(monthlyFeeDropDown.selectedValue, out monthlyFee);
            payable = AdmissionFee + monthlyFee;
            payableForDue = AdmissionFee + monthlyFee;
            TotalPaybleTextbox.Text = payable.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown6_onItemSelected(object sender, EventArgs e)
        {
            payable = 0;
            int.TryParse(AdmissionFeeDropdown.selectedValue, out AdmissionFee);
            payable = AdmissionFee + monthlyFee;
            payableForDue = AdmissionFee + monthlyFee;
            TotalPaybleTextbox.Text = payable.ToString();
        }

        private void DiscountTextbox_OnValueChanged(object sender, EventArgs e)
        {
            int discount = 0;
            int.TryParse(DiscountTextbox.Text, out discount);
            payable = payableForDue - discount;
            TotalPaybleTextbox.Text = payable.ToString();
        }

        private void PaidAmountTextbox_OnValueChanged(object sender, EventArgs e)
        {
            int dueamount = 0;
            int paidAmount = 0;
            int.TryParse(PaidAmountTextbox.Text, out paidAmount);
            dueamount = payable - paidAmount;
            DueTextbox.Text = dueamount.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentList stl = new StudentList();
            this.Hide();
            stl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DailyReport dlr = new DailyReport();
            this.Hide();
            dlr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MonthlyReport mlr = new MonthlyReport();
            this.Hide();
            mlr.Show();
        }

        private void SendSMS(string rollNumber, string amount, string trxID,string mobileNumber,string studentName)
        {
            string result = "";
            WebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                //01711789090
                String to = "01711789090," + mobileNumber; //Recipient Phone Number multiple number must be separated by comma
                String token = "a201640750cff06a9171f13db8412ec1"; //generate token from the control panel
                String message = System.Uri.EscapeUriString("'Byatikram Academic Care'" + 
                                                            " Money Received " + amount +
                                                            "Tk.from " + studentName
                                                            +" roll number " + rollNumber 
                                                            + " .Transaction id " + trxID
                                                            +" For Query:Call 01971789090"); //do not use single quotation (') in the message to avoid forbidden result
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
    }
}
