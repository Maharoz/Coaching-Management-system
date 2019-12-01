using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byatikram
{
    public partial class masterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ByatikramDB;Integrated Security=True");
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
                cmd = new SqlCommand("insert into StudentRegistration(StudentName,StudentRollNumber,DoB) values(@StudentName,@StudentRollNumber,@DoB)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@StudentName", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@StudentRollNumber",bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@GuardiansName", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@Address", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@DoB", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@School", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@Class", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@AdmissionFee", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@MobileNumber", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@Version", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@Course", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@MonthlyFee", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@CourseStartDate", bunifuDatepicker2.Value);
                cmd.Parameters.AddWithValue("@Status", bunifuDatepicker2.Value);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                //DisplayData();
               // ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FeeCollection objFrmMain = new FeeCollection();
           // this.Hide();
            objFrmMain.Show();
        }
    }
}
