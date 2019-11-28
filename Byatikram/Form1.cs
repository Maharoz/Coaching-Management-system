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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ByatikramDB;Integrated Security=True");

            string query = "Select * from Users Where Email='" + bunifuMetroTextbox1.Text.Trim() + "' and password = '" + bunifuMetroTextbox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                masterForm objFrmMain = new masterForm();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }
    }
}
