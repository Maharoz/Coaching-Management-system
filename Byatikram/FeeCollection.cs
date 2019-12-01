using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string rollNo = bunifuMetroTextbox1.Text;
            string name = bunifuMetroTextbox3.Text;
            PrintableForm objFrmMain = new PrintableForm(rollNo,name);
            //this.Hide();
            objFrmMain.Show();
        }
    }
}
