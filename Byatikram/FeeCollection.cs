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
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "ByatikramDB.mdf";
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=celsa.database.windows.net;Initial Catalog=pos-mugdho;User ID=celsa;Password=Qwerty1@3$5");
            SqlCommand cmd;
            SqlDataAdapter adapt;

            string rollNo = bunifuMetroTextbox1.Text;
            string name = bunifuDropdown1.selectedValue + ',' + bunifuDropdown2.selectedValue;
            // string date = bunifuDropdown1.selectedValue + ',' + bunifuDropdown2.selectedValue;
            PrintableForm objFrmMain = new PrintableForm(rollNo,name);
            //this.Hide();
            objFrmMain.Show();


            cmd = new SqlCommand("insert into MoneyCollection(StudentRollNumber,CollectedAmount,CollectorID,CollectionMonth,StudentName) values(@StudentRollNumber,@CollectedAmount,@CollectorID,@CollectionMonth,@StudentName)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@StudentRollNumber", bunifuMetroTextbox1.Text);
            cmd.Parameters.AddWithValue("@CollectedAmount", bunifuMetroTextbox2.Text);
            cmd.Parameters.AddWithValue("@StudentName", bunifuMetroTextbox3.Text);
            cmd.Parameters.AddWithValue("@CollectionMonth", bunifuDropdown1.selectedValue +',' + bunifuDropdown2.selectedValue);
            cmd.Parameters.AddWithValue("@CollectorID", Users.UserID);
          //  cmd.Parameters.AddWithValue("@CollectorName", User.Name);



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
    }
}
