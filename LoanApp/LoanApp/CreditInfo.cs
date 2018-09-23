using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanApp;

namespace LoanApp
{
    public partial class CreditInfo : Form
    {
        public CreditInfo()
        {
            InitializeComponent();
        }

        private void CreditInfo_Load(object sender, EventArgs e)
        {
            using (LoanAppEntities app = new LoanAppEntities())
            {
                app.Customers.ToList().LastOrDefault();
                textBox1.Text = Form1.FN;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LoanAppEntities app = new LoanAppEntities())
            {
                     app.Loans.Add(new Loan
                {
                  LoanDate = Convert.ToDateTime(dateTimePicker1.Text),
                  Amount = Convert.ToDecimal(textBox2.Text)
            });

                app.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
        }
    }
}
