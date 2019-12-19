using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Byatikram
{
    public partial class PrintableForm : Form
    {
        public PrintableForm(string rollNo,string name)
        {
            InitializeComponent();
            textBox1.Text = rollNo;
            textBox2.Text = name;
        }

        private void PrintableForm_Load(object sender, EventArgs e)
        {


            using (Entities db = new Entities())
            {
                int rollNumber;
                int.TryParse(textBox1.Text, out rollNumber);
                GetPaymentReport_ResultBindingSource.DataSource =
                    db.GetPaymentReport(rollNumber, textBox2.Text).FirstOrDefault();

                Microsoft.Reporting.WinForms.ReportParameter[] rParams =
                    new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        //new ReportParameter("RollNumber", textBox1.Text),
                        //new ReportParameter("PaymentMonth", textBox2.Text),
                    };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                int rollNumber;
                int.TryParse(textBox1.Text, out rollNumber);
                GetPaymentReport_ResultBindingSource.DataSource =
                    db.GetPaymentReport(rollNumber, textBox2.Text).FirstOrDefault();

                Microsoft.Reporting.WinForms.ReportParameter[] rParams =
                    new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        //new ReportParameter("RollNumber", textBox1.Text),
                        //new ReportParameter("PaymentMonth", textBox2.Text),
                    };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }
           
        }
    }
}
