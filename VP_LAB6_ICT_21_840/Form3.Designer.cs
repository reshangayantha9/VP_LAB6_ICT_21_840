namespace VP_LAB6_ICT_21_840
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            btnResult = new Button();
            groupBox1 = new GroupBox();
            radioFahrenheit = new RadioButton();
            radioCelsius = new RadioButton();
            txtInput = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 276);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 123, 131);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(126, 219);
            button1.Name = "button1";
            button1.Size = new Size(102, 41);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(2, 123, 131);
            btnResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResult.ForeColor = Color.White;
            btnResult.Location = new Point(18, 219);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(102, 41);
            btnResult.TabIndex = 4;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioFahrenheit);
            groupBox1.Controls.Add(radioCelsius);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(2, 123, 131);
            groupBox1.Location = new Point(18, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Unit";
            // 
            // radioFahrenheit
            // 
            radioFahrenheit.AutoSize = true;
            radioFahrenheit.Location = new Point(21, 59);
            radioFahrenheit.Name = "radioFahrenheit";
            radioFahrenheit.Size = new Size(110, 25);
            radioFahrenheit.TabIndex = 3;
            radioFahrenheit.TabStop = true;
            radioFahrenheit.Text = "Fahrenheit";
            radioFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioCelsius
            // 
            radioCelsius.AutoSize = true;
            radioCelsius.Location = new Point(21, 28);
            radioCelsius.Name = "radioCelsius";
            radioCelsius.Size = new Size(81, 25);
            radioCelsius.TabIndex = 3;
            radioCelsius.TabStop = true;
            radioCelsius.Text = "Celsius";
            radioCelsius.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(18, 63);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(210, 27);
            txtInput.TabIndex = 3;
            txtInput.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(2, 123, 131);
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 3;
            label1.Text = "Enter the temperature";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(370, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(361, 78);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 4;
            label2.Text = "Result";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 123, 131);
            ClientSize = new Size(507, 289);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtInput;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioFahrenheit;
        private RadioButton radioCelsius;
        private Label lblResult;
        private Button btnResult;
        private Button button1;
        private Label label2;
    }
}