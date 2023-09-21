namespace VP_LAB6_ICT_21_840
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnBack = new Button();
            btnGo = new Button();
            listView1 = new ListView();
            iconList = new ImageList(components);
            label1 = new Label();
            txtPath = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblFileName = new Label();
            lblFileType = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Blue;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 33);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.Blue;
            btnGo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGo.ForeColor = Color.White;
            btnGo.Location = new Point(782, 12);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 33);
            btnGo.TabIndex = 1;
            btnGo.Text = "Open";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // listView1
            // 
            listView1.LargeImageList = iconList;
            listView1.Location = new Point(12, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(845, 334);
            listView1.SmallImageList = iconList;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "folder (1).png");
            iconList.Images.SetKeyName(1, "png.png");
            iconList.Images.SetKeyName(2, "exe.png");
            iconList.Images.SetKeyName(3, "mp4.png");
            iconList.Images.SetKeyName(4, "mp3.png");
            iconList.Images.SetKeyName(5, "pdf.png");
            iconList.Images.SetKeyName(6, "doc.png");
            iconList.Images.SetKeyName(7, "file.png");
            iconList.Images.SetKeyName(8, "unknown.png");
            iconList.Images.SetKeyName(9, "folder.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(107, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 4;
            label1.Text = "Path :";
            // 
            // txtPath
            // 
            txtPath.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPath.Location = new Point(153, 12);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(623, 33);
            txtPath.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(12, 397);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 6;
            label2.Text = "File Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(12, 421);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 7;
            label3.Text = "File Type";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileName.ForeColor = Color.Gainsboro;
            lblFileName.Location = new Point(86, 397);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(17, 17);
            lblFileName.TabIndex = 8;
            lblFileName.Text = "...";
            // 
            // lblFileType
            // 
            lblFileType.AutoSize = true;
            lblFileType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileType.ForeColor = Color.Gainsboro;
            lblFileType.Location = new Point(86, 421);
            lblFileType.Name = "lblFileType";
            lblFileType.Size = new Size(17, 17);
            lblFileType.TabIndex = 9;
            lblFileType.Text = "...";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 57);
            ClientSize = new Size(869, 447);
            Controls.Add(lblFileType);
            Controls.Add(lblFileName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPath);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(btnGo);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Explorer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnGo;
        private ListView listView1;
        private Label label1;
        private TextBox txtPath;
        private Label label2;
        private Label label3;
        private Label lblFileName;
        private Label lblFileType;
        private ImageList iconList;
    }
}