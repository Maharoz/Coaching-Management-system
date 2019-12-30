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
using  System.Linq;
using Bunifu.Framework.UI;

namespace Byatikram
{
    public partial class masterFormForEdit : Form
    {
        private int studentId;
        public masterFormForEdit(
            int studentID,
            string studentName,
            string studentRoll,
            string guardiansName,
            string address,
            DateTime DoB,
            string school,
            string classes,
            string admissionFee,
            string mobileNumber,
            string version,
            string course,
            string monthlyFee,
            DateTime courseStartDate,
            string status,
            DateTime admissionDate,
            string referenceRollNumber)
        {
            InitializeComponent();

            studentId = studentID;
            studentNameTextBox.Text = studentName;
            RollNumberTextBox.Text = studentRoll;
            GuardiansNameTextbox.Text = guardiansName;
            AddressTexbox.Text = address;
            ReferenceRollTextBox.Text = referenceRollNumber;
            
            int schoolIndex = MakeDropDownString(schoolDropDown,school);
            schoolDropDown.selectedIndex = schoolIndex;

            int classIndex = MakeDropDownString(classDropdown, classes);
            classDropdown.selectedIndex = classIndex;

            int admissionFeeIndex = MakeDropDownString(AddmissionFeeDropDown, admissionFee);
            AddmissionFeeDropDown.selectedIndex = admissionFeeIndex;

            MobileTextBox.Text = mobileNumber;

            int versionIndex = MakeDropDownString(VersionDropDown, version);
            VersionDropDown.selectedIndex = versionIndex;

            int courseIndex = MakeDropDownString(CourseDropDown, course);
            CourseDropDown.selectedIndex = courseIndex;

            int monthlyFeeIndex = MakeDropDownString(MonthlyFeeDropDown, monthlyFee);
            MonthlyFeeDropDown.selectedIndex = monthlyFeeIndex;

            int statusIndex = MakeDropDownString(StatusDropdown, status);
            StatusDropdown.selectedIndex = statusIndex;

            DateOfBirthPicker.Value = DoB;

        }

        private int MakeDropDownString(BunifuDropdown nameforDropdown,string selectedName)
        {
            int index = nameforDropdown.Items.Select((v, i) => new { Index = i, Value = v }) 
                .Where(p => p.Value == selectedName) 
                .Select(p => p.Index).FirstOrDefault();

            return index;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd,fmd;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            string sql = "";
            cmd = new SqlCommand("update Registration set StudentName=@StudentName," +

                                 "StudentRollNumber=@StudentRollNumber," +
                                 "GuardiansName=@GuardiansName," +
                                 "Address=@Address," +
                                 "DoB=@DoB," +
                                 "School=@School," +
                                 "Class=@Class," +
                                 "AdmissionFee=@AdmissionFee," +
                                 "MobileNumber=@MobileNumber," +
                                 "Version=@Version," +
                                 "Course=@Course," +
                                 "MonthlyFee=@MonthlyFee," +
                                 "CourseStartDate=@CourseStartDate," +
                                 "Status=@Status," +
                                 "RefrenceRollNumber = @RefrenceRollNumber," +
                                 "CreatedBy=@CreatedBy where StudentID=@StudentID"
                              , sqlcon);

            fmd = new SqlCommand(@"update Reference
                set ReferenceRollNumber = @ReferenceRollNumber where ReferedFor= @ReferedFor", sqlcon);

            sqlcon.Open();
            cmd.Parameters.AddWithValue("@StudentID", studentId);
            cmd.Parameters.AddWithValue("@StudentName", studentNameTextBox.Text);

            int rollNumber;
            if (int.TryParse(RollNumberTextBox.Text, out rollNumber))
            {
                cmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
                fmd.Parameters.AddWithValue("@ReferedFor", rollNumber);

            }

            cmd.Parameters.AddWithValue("@GuardiansName", GuardiansNameTextbox.Text);
            cmd.Parameters.AddWithValue("@Address", AddressTexbox.Text);
            cmd.Parameters.AddWithValue("@DoB", DateOfBirthPicker.Value);
            cmd.Parameters.AddWithValue("@School", schoolDropDown.selectedValue);
            cmd.Parameters.AddWithValue("@Class", classDropdown.selectedValue);
            cmd.Parameters.AddWithValue("@AdmissionFee", AddmissionFeeDropDown.selectedValue);
            cmd.Parameters.AddWithValue("@MobileNumber", MobileTextBox.Text);
            cmd.Parameters.AddWithValue("@Version", VersionDropDown.selectedValue);
            cmd.Parameters.AddWithValue("@Course", CourseDropDown.selectedValue);
            cmd.Parameters.AddWithValue("@MonthlyFee", MonthlyFeeDropDown.selectedValue);
            cmd.Parameters.AddWithValue("@CourseStartDate", bunifuDatepicker3.Value);
            cmd.Parameters.AddWithValue("@Status", StatusDropdown.selectedValue);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Today);
            cmd.Parameters.AddWithValue("@CreatedBy", Users.UserID);


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
            cmd.ExecuteNonQuery();
            fmd.ExecuteNonQuery();
            sqlcon.Close();
            
            StudentList sl = new StudentList();
            sl.Show();
            this.Hide();

            MessageBox.Show("Record Updated Successfully");

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
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown6_onItemSelected(object sender, EventArgs e)
        {
         
        }

        private void DiscountTextbox_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void PaidAmountTextbox_OnValueChanged(object sender, EventArgs e)
        {
          
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

        private void SendSMS(string rollNumber, string amount, string trxID,string mobileNumber)
        {
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand dmd;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            dmd = new SqlCommand(@"delete Registration 
                 where StudentID= @StudentID", sqlcon);

            sqlcon.Open();
            dmd.Parameters.AddWithValue("@StudentID", studentId);
            dmd.ExecuteNonQuery();
            sqlcon.Close();

            StudentList sl = new StudentList();
            sl.Show();
            this.Hide();
            MessageBox.Show("Record Deleted Successfully");
        }
    }
}
