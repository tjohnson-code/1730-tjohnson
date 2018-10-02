using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjohnson2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subTotal = Convert.ToInt32(txtSubtotal.Text);

            decimal percent = Convert.ToInt32(txtDiscountPercent.Text);         

            decimal discountAmount = (subTotal * percent) / 100;
            txtDiscountAmount.Text = discountAmount.ToString("0.00");

            decimal total = subTotal - discountAmount;
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
