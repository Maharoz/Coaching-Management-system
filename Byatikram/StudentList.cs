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
    }
}
