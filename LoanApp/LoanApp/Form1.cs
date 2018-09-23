using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace LoanApp
{
    public partial class Form1 : Form
    {
        public static string FN;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             FN = textBox1.Text;
            CreditInfo info = new CreditInfo();
            info.ShowDialog();

            using (LoanAppEntities loanapp = new LoanAppEntities())
            {
                loanapp.Customers.Add(new Customer
                {
                    Name = FN,
                    Passport = textBox2.Text
                });

                loanapp.SaveChanges();    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
