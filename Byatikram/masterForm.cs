using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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
            else
            {
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
                                            StudentName,CollectionDate,CollectionType,OtherDiscount) values(@StudentRollNumber,@CollectedAmount,@CollectorID,
                                            @CollectionMonth,@StudentName,@CollectionDate,@CollectionType,@OtherDiscount)", con);
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

                cmd.Parameters.AddWithValue("@GuardiansName", GuardiansNameTextbox.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTexbox.Text);
                cmd.Parameters.AddWithValue("@DoB", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@School", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@Class", bunifuDropdown3.selectedValue);
                cmd.Parameters.AddWithValue("@AdmissionFee", bunifuDropdown6.selectedValue);
                cmd.Parameters.AddWithValue("@MobileNumber", MobileTextBox.Text);
                cmd.Parameters.AddWithValue("@Version", bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@Course", bunifuDropdown4.selectedValue);
                cmd.Parameters.AddWithValue("@MonthlyFee", bunifuDropdown5.selectedValue);
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

                gmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                gmd.Parameters.AddWithValue("@CollectedAmount", paidAmountDuringAddmission.ToString());
                gmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);
                gmd.Parameters.AddWithValue("@CollectionMonth", string.Empty);
                gmd.Parameters.AddWithValue("@CollectorID", Users.UserID);
                gmd.Parameters.AddWithValue("@CollectionDate", DateTime.Today);
                gmd.Parameters.AddWithValue("@CollectionType", "Admission");
                gmd.Parameters.AddWithValue("@OtherDiscount", DiscountTextbox.Text);

                    cmd.ExecuteNonQuery();
                dmd.ExecuteNonQuery();
                fmd.ExecuteNonQuery();
                gmd.ExecuteNonQuery();

                    con.Close();
                MessageBox.Show("Record Inserted Successfully");

                masterForm NewForm = new masterForm();
                NewForm.Show();
                this.Dispose(false);
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
            int.TryParse(bunifuDropdown5.selectedValue, out monthlyFee);
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
            int.TryParse(bunifuDropdown6.selectedValue, out AdmissionFee);
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
    }
}
