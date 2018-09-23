using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApp
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Table_Load(object sender, EventArgs e)
        {
            using (LoanAppEntities loanapp = new LoanAppEntities())
            {
                dataGridView1.DataSource = loanapp.Customers.ToList();
            }

            
        }
    }
}
