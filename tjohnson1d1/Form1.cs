using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjohnson1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.76";
            txtAmountUnitedKingdom.Text = "0.00";
            txtRateUnitedKingdom.Text = "1.29";
            txtAmountRussia.Text = "0.00";
            txtRateRussia.Text = "0.015";
            txtAmountChina.Text = "0.00";
            txtRateChina.Text = "0.15";

        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
              Convert.ToDecimal(txtAmountCanada.Text)
             * Convert.ToDecimal(txtRateCanada.Text)
                ).ToString("0.00");
        }

        private void unitedkingdomTextChanged(object sender, EventArgs e)
        {
            txtUSDUnitedKingdom.Text = (
             Convert.ToDecimal(txtAmountUnitedKingdom.Text)
                * Convert.ToDecimal(txtRateUnitedKingdom.Text)
                 ).ToString("0.00");
        }

        private void russiaTextChanged(object sender, EventArgs e)
        {
            txtUSDRussia.Text = (
             Convert.ToDecimal(txtAmountRussia.Text)
                * Convert.ToDecimal(txtRateRussia.Text)
                ).ToString("0.00");
        }

        private void chinaTextChanged(object sender, EventArgs e)
        {
            txtUSDChina.Text = (
              Convert.ToDecimal(txtAmountChina.Text)
             * Convert.ToDecimal(txtRateChina.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
              Convert.ToDecimal(txtUSDCanada.Text)
              + Convert.ToDecimal(txtUSDUnitedKingdom.Text)
              + Convert.ToDecimal(txtUSDRussia.Text)
              + Convert.ToDecimal(txtUSDChina.Text)
                ).ToString("0.00");
        }
    }
    
}
