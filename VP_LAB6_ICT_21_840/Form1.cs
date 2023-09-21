namespace VP_LAB6_ICT_21_840
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal num1;
        decimal num2;
        decimal result;
        char op = ' ';
        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            op = '+';
            num1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            op = '-';
            num1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            op = '*';
            num1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            op = '/';
            num1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(txtDisplay.Text);
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    lblCal.Text = "" + num1 + "+" + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    lblCal.Text = "" + num1 + "-" + num2;
                    break;
                case '*':
                    result = num1 * num2;
                    lblCal.Text = "" + num1 + "*" + num2;
                    break;
                case '/':
                    result = num1 / num2;
                    lblCal.Text = "" + num1 + "/" + num2;
                    break;
            }
            txtDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblCal.Text = "";
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
    }
}