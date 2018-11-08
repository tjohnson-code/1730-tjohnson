using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjohnson2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1A) 'Switch' with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1ATextBox.Text);

            // 1B) Separate 'if' statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1ATextBox.Text);

            // 1C) If elseif
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1ATextBox.Text);

            // 1D) Nested if-else
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1ATextBox.Text);

            // 1E) 'Switch' with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1ATextBox.Text);

            // 1F) Separate 'if' statements with default
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(input1ATextBox.Text);

            // 1G) If elseif with default
            resultElseIfDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1ATextBox.Text);

            // 1H) Nested if-else with default
            resultNestedIfElseDefault01TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1ATextBox.Text);

            // 2A) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input2ATextBox.Text);

            // 2B) Separate 'if' statements with no default
            resultIf02TextBox.Text = Ex2gCalculations.If02(input2ATextBox.Text);

            // 2C) if elseif without default
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(input2ATextBox.Text);

            // 2D) Nested if-else without default
            resultNestedIfElse02TextBox.Text = Ex2gCalculations.NestedIfElse02(input2ATextBox.Text);
        }
    }
}
