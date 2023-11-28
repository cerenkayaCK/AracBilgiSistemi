namespace CodeFirstOrnek
{
    partial class ArabaEkle
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
            txtModel = new TextBox();
            txtMarka = new TextBox();
            txtMesafe = new TextBox();
            txtRenk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTamam = new Button();
            grpEkle = new GroupBox();
            button1 = new Button();
            label8 = new Label();
            txtSahipId = new TextBox();
            label6 = new Label();
            cmbPlakalar = new ComboBox();
            label5 = new Label();
            cmbMuhendisler = new ComboBox();
            groupBox1 = new GroupBox();
            lstMuhendisler = new ListBox();
            button2 = new Button();
            grpEkle.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtModel
            // 
            txtModel.Location = new Point(28, 37);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(97, 23);
            txtModel.TabIndex = 0;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(28, 81);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(97, 23);
            txtMarka.TabIndex = 1;
            // 
            // txtMesafe
            // 
            txtMesafe.Location = new Point(146, 38);
            txtMesafe.Name = "txtMesafe";
            txtMesafe.Size = new Size(100, 23);
            txtMesafe.TabIndex = 2;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(146, 82);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(100, 23);
            txtRenk.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 20);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "mesafe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 64);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "renk";
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(167, 256);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(250, 26);
            btnTamam.TabIndex = 8;
            btnTamam.Text = "KAYDET";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // grpEkle
            // 
            grpEkle.Controls.Add(button1);
            grpEkle.Controls.Add(label8);
            grpEkle.Controls.Add(txtSahipId);
            grpEkle.Controls.Add(label6);
            grpEkle.Controls.Add(cmbPlakalar);
            grpEkle.Controls.Add(label5);
            grpEkle.Controls.Add(label4);
            grpEkle.Controls.Add(label3);
            grpEkle.Controls.Add(label2);
            grpEkle.Controls.Add(label1);
            grpEkle.Controls.Add(txtRenk);
            grpEkle.Controls.Add(txtMesafe);
            grpEkle.Controls.Add(txtMarka);
            grpEkle.Controls.Add(txtModel);
            grpEkle.Location = new Point(21, 12);
            grpEkle.Name = "grpEkle";
            grpEkle.Size = new Size(271, 238);
            grpEkle.TabIndex = 10;
            grpEkle.TabStop = false;
            grpEkle.Text = "Araba Özellikleri";
            // 
            // button1
            // 
            button1.Location = new Point(168, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Yeni Kişi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 171);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 14;
            label8.Text = "Id";
            // 
            // txtSahipId
            // 
            txtSahipId.Location = new Point(28, 189);
            txtSahipId.Name = "txtSahipId";
            txtSahipId.Size = new Size(100, 23);
            txtSahipId.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 171);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // cmbPlakalar
            // 
            cmbPlakalar.DisplayMember = "PlakaKod";
            cmbPlakalar.FormattingEnabled = true;
            cmbPlakalar.Location = new Point(28, 135);
            cmbPlakalar.Name = "cmbPlakalar";
            cmbPlakalar.Size = new Size(218, 23);
            cmbPlakalar.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 117);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Plaka";
            // 
            // cmbMuhendisler
            // 
            cmbMuhendisler.FormattingEnabled = true;
            cmbMuhendisler.Location = new Point(17, 29);
            cmbMuhendisler.Name = "cmbMuhendisler";
            cmbMuhendisler.Size = new Size(121, 23);
            cmbMuhendisler.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(lstMuhendisler);
            groupBox1.Controls.Add(cmbMuhendisler);
            groupBox1.Location = new Point(298, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 238);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Muhendisler";
            // 
            // lstMuhendisler
            // 
            lstMuhendisler.FormattingEnabled = true;
            lstMuhendisler.ItemHeight = 15;
            lstMuhendisler.Location = new Point(17, 72);
            lstMuhendisler.Name = "lstMuhendisler";
            lstMuhendisler.Size = new Size(202, 124);
            lstMuhendisler.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(156, 27);
            button2.Name = "button2";
            button2.Size = new Size(63, 25);
            button2.TabIndex = 13;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            // 
            // ArabaEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 304);
            Controls.Add(grpEkle);
            Controls.Add(btnTamam);
            Controls.Add(groupBox1);
            Name = "ArabaEkle";
            Text = "Form2";
            Load += Form2_Load;
            grpEkle.ResumeLayout(false);
            grpEkle.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtModel;
        private TextBox txtMarka;
        private TextBox txtMesafe;
        private TextBox txtRenk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTamam;
        private GroupBox grpEkle;
        private Label label5;
        private ComboBox cmbPlakalar;
        private Button button1;
        private Label label8;
        private TextBox txtSahipId;
        private Label label6;
        private ComboBox cmbMuhendisler;
        private GroupBox groupBox1;
        private Button button2;
        private ListBox lstMuhendisler;
    }
}