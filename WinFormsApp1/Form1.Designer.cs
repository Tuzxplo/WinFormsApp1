using System.ComponentModel.DataAnnotations;


namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnthem = new System.Windows.Forms.Button();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dayso = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cble = new System.Windows.Forms.CheckBox();
            this.cbchan = new System.Windows.Forms.CheckBox();
            this.yeucau = new System.Windows.Forms.ComboBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthem.Location = new System.Drawing.Point(31, 97);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(125, 29);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "them";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            this.btnthem.Enter += new System.EventHandler(this.ente);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(31, 35);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(125, 27);
            this.txtnhap.TabIndex = 1;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnhap);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(62, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nhap so";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "so";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dayso
            // 
            this.dayso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dayso.FormattingEnabled = true;
            this.dayso.ItemHeight = 20;
            this.dayso.Location = new System.Drawing.Point(314, 52);
            this.dayso.Name = "dayso";
            this.dayso.Size = new System.Drawing.Size(150, 324);
            this.dayso.TabIndex = 3;
            this.dayso.SelectedIndexChanged += new System.EventHandler(this.dayso_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.cble);
            this.groupBox2.Controls.Add(this.cbchan);
            this.groupBox2.Controls.Add(this.yeucau);
            this.groupBox2.Controls.Add(this.btntinh);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(62, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 183);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "cach thuc";
            // 
            // cble
            // 
            this.cble.AutoSize = true;
            this.cble.Location = new System.Drawing.Point(43, 89);
            this.cble.Name = "cble";
            this.cble.Size = new System.Drawing.Size(43, 24);
            this.cble.TabIndex = 3;
            this.cble.Text = "le";
            this.cble.UseVisualStyleBackColor = true;
            this.cble.CheckedChanged += new System.EventHandler(this.cble_CheckedChanged);
            // 
            // cbchan
            // 
            this.cbchan.AutoSize = true;
            this.cbchan.Location = new System.Drawing.Point(43, 60);
            this.cbchan.Name = "cbchan";
            this.cbchan.Size = new System.Drawing.Size(62, 24);
            this.cbchan.TabIndex = 2;
            this.cbchan.Text = "chan";
            this.cbchan.UseVisualStyleBackColor = true;
            this.cbchan.CheckedChanged += new System.EventHandler(this.cbchan_CheckedChanged);
            // 
            // yeucau
            // 
            this.yeucau.FormattingEnabled = true;
            this.yeucau.Items.AddRange(new object[] {
            "tong ",
            "tich"});
            this.yeucau.Location = new System.Drawing.Point(17, 26);
            this.yeucau.Name = "yeucau";
            this.yeucau.Size = new System.Drawing.Size(151, 28);
            this.yeucau.TabIndex = 1;
            this.yeucau.Text = "phep tinh";
            this.yeucau.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btntinh
            // 
            this.btntinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntinh.Location = new System.Drawing.Point(31, 119);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(125, 29);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "tinh";
            this.btntinh.UseVisualStyleBackColor = false;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtkq
            // 
            this.txtkq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtkq.Location = new System.Drawing.Point(137, 417);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(629, 27);
            this.txtkq.TabIndex = 5;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ket qua";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(564, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.FnSZ6Gy3Dv0haIJ8PExUu7o4;
            this.pictureBox1.Location = new System.Drawing.Point(564, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset.Location = new System.Drawing.Point(347, 382);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 29);
            this.reset.TabIndex = 9;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dayso);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "app tinh toan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnthem;
        private TextBox txtnhap;
        private GroupBox groupBox1;
        private ListBox dayso;
        private GroupBox groupBox2;
        private Button btntinh;
        private TextBox txtkq;
        private ComboBox yeucau;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button reset;
        private CheckBox cble;
        private CheckBox cbchan;
    }
}