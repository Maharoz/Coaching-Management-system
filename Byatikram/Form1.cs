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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");

            string query = "Select * from Users Where Email='" + EmailTextBox.Text.Trim() + "' and password = '" + PasswordText.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);



            using (SqlConnection connection = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                   
                    Users.Name = (read["Name"].ToString());
                    Users.Email = (read["Email"].ToString());
                    Users.UserID = (read["UserID"].ToString());
                }
                read.Close();
            }

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
