using real_estate.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void LoadGiaoDien()
        {
            
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            employee2.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer3.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            products1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            bill1.BringToFront();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            projects1.BringToFront();
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
