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
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "ByatikramDB.mdf";
      //  SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
        SqlCommand cmd;
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
            if (bunifuMetroTextbox1.Text != "" && bunifuMetroTextbox2.Text != "")
            {
                cmd = new SqlCommand("insert into StudentRegistration(StudentName,StudentRollNumber," +
                                     "GuardiansName,DoB,School,Class,AdmissionFee," +
                                     "MobileNumber,Version,Course,MonthlyFee,CourseStartDate,Status,CreationDate,CreatedBy) " +
                                     "values(@StudentName," +
                                     "@StudentRollNumber,@GuardiansName,@DoB,@School," +
                                     "@Class,@AdmissionFee,@MobileNumber,@Version" +
                                     ",@Course,@MonthlyFee,@CourseStartDate,@Status,@CreationDate,@CreatedBy)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@StudentName", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@StudentRollNumber",bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@GuardiansName", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@Address", bunifuMetroTextbox4.Text);
                cmd.Parameters.AddWithValue("@DoB", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@School", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@Class", bunifuDropdown3.Text);
                cmd.Parameters.AddWithValue("@AdmissionFee", bunifuDropdown6.selectedValue);
                cmd.Parameters.AddWithValue("@MobileNumber", bunifuMetroTextbox5.Text);
                cmd.Parameters.AddWithValue("@Version", bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@Course", bunifuDropdown4.selectedValue);
                cmd.Parameters.AddWithValue("@MonthlyFee", bunifuDropdown5.selectedValue);
                cmd.Parameters.AddWithValue("@CourseStartDate", bunifuDatepicker3.Value);
                cmd.Parameters.AddWithValue("@Status", bunifuDropdown7.selectedValue);
                cmd.Parameters.AddWithValue("@CreationDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@CreatedBy", Users.UserID);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                //DisplayData();
               // ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Required Fields!");
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

        }
    }
}
