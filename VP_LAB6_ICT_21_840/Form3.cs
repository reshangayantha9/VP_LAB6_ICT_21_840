using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LAB6_ICT_21_840
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double inputValue))
            {
                if (radioCelsius.Checked)
                {
                    double celsius = (inputValue - 32) * 5 / 9;
                    lblResult.Text = celsius.ToString("0.00");
                }
                else if (radioFahrenheit.Checked)
                {
                    double fahrenheit = (inputValue * 9 / 5) + 32;
                    lblResult.Text = fahrenheit.ToString("0.00");
                }

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid Fahrenheit temperature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtInput.Text = "";
        }
    }
}
