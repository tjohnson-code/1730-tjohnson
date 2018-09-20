using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjohnson1f1
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            btnUnitedKingdom.BackgroundImage = picUnitedKingdomDim.Image;
            txtRate.Text = "0.76";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnCanada.Text + ": ";            
            txtCurrency.Focus();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            btnUnitedKingdom.BackgroundImage = picUnitedKingdomDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.76";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnCanada.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnChina_Click(object sender, EventArgs e)
        {
            btnChina.BackgroundImage = picChina.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            btnUnitedKingdom.BackgroundImage = picUnitedKingdomDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.15";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnChina.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnRussia_Click(object sender, EventArgs e)
        {
            btnRussia.BackgroundImage = picRussia.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnUnitedKingdom.BackgroundImage = picUnitedKingdomDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.015";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnRussia.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnUnitedKingdom_Click(object sender, EventArgs e)
        {
            btnUnitedKingdom.BackgroundImage = picUnitedKingdom.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = "1.29";
            txtUSDollars.Text = "0.00";
            lblCurrency.Text = btnUnitedKingdom.Text + ": ";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
              Convert.ToDecimal(txtCurrency.Text)
             * Convert.ToDecimal(txtRate.Text)
             ).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text)
                + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");

            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;

            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.76";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
            btnCanada.BackgroundImage = picCanada.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            btnUnitedKingdom.BackgroundImage = picUnitedKingdomDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtCurrency.Focus();
        }
    }
}
