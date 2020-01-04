using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Microsoft.Reporting.WinForms;

namespace Byatikram
{
    public partial class PrintableForm : Form
    {
        public PrintableForm(string rollNo,string name,string collectionType)
        {
            InitializeComponent();
            textBox1.Text = rollNo;
            textBox2.Text = name;
            int feeTypeIndex = MakeDropDownString(FeeTypePicker, collectionType);
            FeeTypePicker.selectedIndex = feeTypeIndex;
        }


        private int MakeDropDownString(BunifuDropdown nameforDropdown, string selectedName)
        {
            int index = nameforDropdown.Items.Select((v, i) => new { Index = i, Value = v })
                .Where(p => p.Value == selectedName)
                .Select(p => p.Index).FirstOrDefault();

            return index;
        }

        private void PrintableForm_Load(object sender, EventArgs e)
        {


            using (Entities1 db = new Entities1())
            {
                int rollNumber;
                int.TryParse(textBox1.Text, out rollNumber);
                getPaymentReportWithTypeResultBindingSource.DataSource =
                    db.GetPaymentReportWithType(rollNumber, textBox2.Text,FeeTypePicker.selectedValue).FirstOrDefault();

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
            using (Entities1 db = new Entities1())
            {
                int rollNumber;
                int.TryParse(textBox1.Text, out rollNumber);
                getPaymentReportWithTypeResultBindingSource.DataSource =
                db.GetPaymentReportWithType(rollNumber, textBox2.Text, FeeTypePicker.selectedValue).FirstOrDefault();

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
