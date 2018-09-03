using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjohnson1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotdogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
                5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");

            txtPretaxTotal.Text = (
             Convert.ToDecimal(txtHotdogsSubtotal.Text)
             + Convert.ToDecimal(txtHamburgersSubtotal.Text)
             ).ToString("0.00");

            txtTax.Text = (
                .06875m
                * Convert.ToDecimal(txtPretaxTotal.Text)
            ).ToString("0.00");

            txtTotal.Text = (
             Convert.ToDecimal(txtTax.Text)
             + Convert.ToDecimal(txtPretaxTotal.Text)
             ).ToString("0.00");

            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotdogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }
    }
}
