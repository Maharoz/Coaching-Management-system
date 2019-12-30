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
using Byatikram.Properties;

namespace Byatikram
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5"))
            {
               
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from registration",connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masterForm objFrmMain = new masterForm();
            this.Hide();
            objFrmMain.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            int studentID = (int)row.Cells[0].Value;
            string studentName = row.Cells[1].Value.ToString();
            string studentRoll = row.Cells[2].Value.ToString();
            string guardiansName = row.Cells[3].Value.ToString();
            string address = row.Cells[4].Value.ToString();
            DateTime dateOfBirth = (DateTime) row.Cells[5].Value;
            string school = row.Cells[6].Value.ToString();
            string classes = row.Cells[7].Value.ToString();
            string admissionFee = row.Cells[8].Value.ToString();
            string mobileNumber = row.Cells[9].Value.ToString();
            string version = row.Cells[10].Value.ToString();
            string course = row.Cells[11].Value.ToString();
            string monthlyFee = row.Cells[12].Value.ToString();
            DateTime courseStartDate = (DateTime)row.Cells[13].Value;
            string status = row.Cells[14].Value.ToString();
            DateTime admissionDate = (DateTime)row.Cells[15].Value;
            string referenceRollNumber = row.Cells[17].Value.ToString();
            masterFormForEdit objMasterEdit = new masterFormForEdit(
                studentID,
               studentName,
             studentRoll,
             guardiansName,
             address,
             dateOfBirth,
             school,
             classes,
             admissionFee,
             mobileNumber,
             version,
             course,
             monthlyFee,
             courseStartDate,
             status,
             admissionDate,
                referenceRollNumber);
            objMasterEdit.Show();
            this.Hide();

        }

        
        
    }
}
