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
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ByatikramDB;Integrated Security=True");
            SqlCommand cmd;
            SqlDataAdapter adapt;

            string rollNo = bunifuMetroTextbox1.Text;
            string name = bunifuMetroTextbox3.Text;
            PrintableForm objFrmMain = new PrintableForm(rollNo,name);
            //this.Hide();
            objFrmMain.Show();


            cmd = new SqlCommand("insert into MoneyCollection(StudentRollNumber,CollectedAmount,CollectorID,CollectionMonth,StudentName) values(@StudentRollNumber,@CollectedAmount,@CollectorID,@CollectionMonth,@StudentName)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@StudentRollNumber", bunifuMetroTextbox1.Text);
            cmd.Parameters.AddWithValue("@CollectedAmount", bunifuMetroTextbox2.Text);
            cmd.Parameters.AddWithValue("@StudentName", bunifuMetroTextbox3.Text);
            cmd.Parameters.AddWithValue("@CollectionMonth", bunifuDropdown1.selectedValue +',' + bunifuDropdown2.selectedValue);
            cmd.Parameters.AddWithValue("@CollectorID", User.UserID);
           // cmd.Parameters.AddWithValue("@School", bunifuDropdown1.selectedValue);
         


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }
    }
}
