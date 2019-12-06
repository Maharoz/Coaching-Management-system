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
using Microsoft.Win32;

namespace Byatikram
{
    public partial class FeeCollection : Form
    {
        public FeeCollection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            SqlCommand cmd;
            SqlDataAdapter adapt;

            string rollNo = StudentRollTextBox.Text;
            string name = bunifuDropdown1.selectedValue + ',' + bunifuDropdown2.selectedValue;
            PrintableForm objFrmMain = new PrintableForm(rollNo,name);
            objFrmMain.Show();


            cmd = new SqlCommand("insert into MoneyCollection(StudentRollNumber,CollectedAmount,CollectorID,CollectionMonth,StudentName) values(@StudentRollNumber,@CollectedAmount,@CollectorID,@CollectionMonth,@StudentName)", con);
            con.Open();

            int rollNumber;
            if (int.TryParse(StudentRollTextBox.Text, out rollNumber))
            {
                cmd.Parameters.AddWithValue("@StudentRollNumber", rollNumber);
            }
            cmd.Parameters.AddWithValue("@CollectedAmount", AmountTextBox.Text);
            cmd.Parameters.AddWithValue("@StudentName", StudentNameTextBox.Text);
            cmd.Parameters.AddWithValue("@CollectionMonth", bunifuDropdown1.selectedValue +',' + bunifuDropdown2.selectedValue);
            cmd.Parameters.AddWithValue("@CollectorID", Users.UserID);



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masterForm objFrmMain = new masterForm();
            this.Hide();
            objFrmMain.Show();
        }

        private void StudentRollTextBox_OnValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            SqlCommand cmd;
            SqlDataAdapter adapt;
            int rollNumber;
            int.TryParse(StudentRollTextBox.Text, out rollNumber);
            DataTable td = new DataTable();
            adapt = new SqlDataAdapter("select StudentName from Registration where StudentRollNumber =" + rollNumber , con);
            con.Open();
            adapt.Fill(td);
            con.Close();
            if (td.Rows.Count > 0)
            {
                StudentNameTextBox.Text = td.Rows[0].ItemArray[0].ToString();
            }
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
