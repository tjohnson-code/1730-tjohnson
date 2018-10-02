using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjohnson2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            //Canada Conversion
            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = Convert.ToDecimal(txtRateCanada.Text);
            decimal usdCanada = amountCanada * rateCanada;
            txtUSDCanada.Text = usdCanada.ToString("0.00");

            //UK Conversion
            decimal amountUK = Convert.ToDecimal(txtAmountUnitedKingdom.Text);
            decimal rateUK = Convert.ToDecimal(txtRateUnitedKingdom.Text);
            decimal usdUK = amountUK * rateUK;
            txtUSDUnitedKingdom.Text = usdUK.ToString("0.00");

            //Russia Conversion
            decimal amountRussia = Convert.ToDecimal(txtAmountRussia.Text);
            decimal rateRussia = Convert.ToDecimal(txtRateRussia.Text);
            decimal usdRussia = amountRussia * rateRussia;
            txtUSDRussia.Text = usdRussia.ToString("0.00");

            //China Conversion
            decimal amountChina = Convert.ToDecimal(txtAmountChina.Text);
            decimal rateChina = Convert.ToDecimal(txtRateChina.Text);
            decimal usdChina = amountChina * rateChina;
            txtUSDChina.Text = usdChina.ToString("0.00");

            //Total
            decimal totalUSD = usdCanada + usdUK + usdRussia + usdChina;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset Event
            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.76";
            txtAmountUnitedKingdom.Text = "0.00";
            txtRateUnitedKingdom.Text = "1.29";
            txtAmountRussia.Text = "0.00";
            txtRateRussia.Text = "0.015";
            txtAmountChina.Text = "0.00";
            txtRateChina.Text = "0.15";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit Program
            this.Close();
        }
    }
}
