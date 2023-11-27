namespace CodeFirstOrnek
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
            if(disposing) { disposing = true; }
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
            lstArabalar = new ListBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtArabaId = new TextBox();
            lbla = new Label();
            rdMarka = new RadioButton();
            rdModel = new RadioButton();
            rdMesafe = new RadioButton();
            rdRenk = new RadioButton();
            groupBox1 = new GroupBox();
            btnAramaYap = new Button();
            txtArama = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnPlakaGuncelle = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstArabalar
            // 
            lstArabalar.BackColor = SystemColors.MenuBar;
            lstArabalar.DisplayMember = "none";
            lstArabalar.ForeColor = Color.DarkGray;
            lstArabalar.FormattingEnabled = true;
            lstArabalar.ItemHeight = 15;
            lstArabalar.Location = new Point(13, 8);
            lstArabalar.Margin = new Padding(4, 2, 4, 2);
            lstArabalar.Name = "lstArabalar";
            lstArabalar.Size = new Size(381, 274);
            lstArabalar.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkGray;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(590, 8);
            btnEkle.Margin = new Padding(4, 2, 4, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(147, 87);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Araba Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkGray;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(92, 288);
            btnSil.Margin = new Padding(4, 2, 4, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 72);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkGray;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(402, 8);
            btnGuncelle.Margin = new Padding(4, 2, 4, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(190, 87);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Araba Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtArabaId
            // 
            txtArabaId.BackColor = SystemColors.Menu;
            txtArabaId.Location = new Point(13, 321);
            txtArabaId.Margin = new Padding(4, 2, 4, 2);
            txtArabaId.Name = "txtArabaId";
            txtArabaId.Size = new Size(71, 23);
            txtArabaId.TabIndex = 5;
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Font = new Font("Segoe UI Semilight", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbla.ForeColor = SystemColors.InfoText;
            lbla.Location = new Point(17, 307);
            lbla.Margin = new Padding(4, 0, 4, 0);
            lbla.Name = "lbla";
            lbla.Size = new Size(49, 11);
            lbla.TabIndex = 4;
            lbla.Text = "ArabaId : ";
            // 
            // rdMarka
            // 
            rdMarka.AutoSize = true;
            rdMarka.Location = new Point(130, 68);
            rdMarka.Margin = new Padding(4, 2, 4, 2);
            rdMarka.Name = "rdMarka";
            rdMarka.Size = new Size(57, 19);
            rdMarka.TabIndex = 6;
            rdMarka.TabStop = true;
            rdMarka.Text = "Marka";
            rdMarka.UseVisualStyleBackColor = true;
            // 
            // rdModel
            // 
            rdModel.AutoSize = true;
            rdModel.Location = new Point(25, 68);
            rdModel.Margin = new Padding(4, 2, 4, 2);
            rdModel.Name = "rdModel";
            rdModel.Size = new Size(58, 19);
            rdModel.TabIndex = 7;
            rdModel.TabStop = true;
            rdModel.Text = "Model";
            rdModel.UseVisualStyleBackColor = true;
            // 
            // rdMesafe
            // 
            rdMesafe.AutoSize = true;
            rdMesafe.Location = new Point(25, 116);
            rdMesafe.Margin = new Padding(4, 2, 4, 2);
            rdMesafe.Name = "rdMesafe";
            rdMesafe.Size = new Size(62, 19);
            rdMesafe.TabIndex = 8;
            rdMesafe.TabStop = true;
            rdMesafe.Text = "Mesafe";
            rdMesafe.UseVisualStyleBackColor = true;
            // 
            // rdRenk
            // 
            rdRenk.AutoSize = true;
            rdRenk.Location = new Point(130, 116);
            rdRenk.Margin = new Padding(4, 2, 4, 2);
            rdRenk.Name = "rdRenk";
            rdRenk.Size = new Size(51, 19);
            rdRenk.TabIndex = 9;
            rdRenk.TabStop = true;
            rdRenk.Text = "Renk";
            rdRenk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAramaYap);
            groupBox1.Controls.Add(txtArama);
            groupBox1.Controls.Add(rdRenk);
            groupBox1.Controls.Add(rdMarka);
            groupBox1.Controls.Add(rdMesafe);
            groupBox1.Controls.Add(rdModel);
            groupBox1.ForeColor = SystemColors.MenuText;
            groupBox1.Location = new Point(509, 99);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(228, 261);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arama";
            // 
            // btnAramaYap
            // 
            btnAramaYap.BackColor = Color.DarkGray;
            btnAramaYap.ForeColor = Color.White;
            btnAramaYap.Location = new Point(8, 212);
            btnAramaYap.Margin = new Padding(4, 2, 4, 2);
            btnAramaYap.Name = "btnAramaYap";
            btnAramaYap.Size = new Size(210, 37);
            btnAramaYap.TabIndex = 11;
            btnAramaYap.Text = "Ara";
            btnAramaYap.UseVisualStyleBackColor = false;
            btnAramaYap.Click += btnAramaYap_Click;
            // 
            // txtArama
            // 
            txtArama.BackColor = SystemColors.Menu;
            txtArama.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            txtArama.Location = new Point(8, 176);
            txtArama.Margin = new Padding(4, 2, 4, 2);
            txtArama.Multiline = true;
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(210, 32);
            txtArama.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(199, 288);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(204, 72);
            button1.TabIndex = 11;
            button1.Text = "ARABALARI GÖSTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(402, 95);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(99, 133);
            button2.TabIndex = 12;
            button2.Text = "Yeni Plaka Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnPlakaGuncelle
            // 
            btnPlakaGuncelle.BackColor = Color.DarkGray;
            btnPlakaGuncelle.ForeColor = Color.White;
            btnPlakaGuncelle.Location = new Point(402, 228);
            btnPlakaGuncelle.Margin = new Padding(4, 2, 4, 2);
            btnPlakaGuncelle.Name = "btnPlakaGuncelle";
            btnPlakaGuncelle.Size = new Size(99, 132);
            btnPlakaGuncelle.TabIndex = 13;
            btnPlakaGuncelle.Text = "Plaka Guncelle";
            btnPlakaGuncelle.UseVisualStyleBackColor = false;
            btnPlakaGuncelle.Click += btnPlakaGuncelle_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semilight", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(270, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 102);
            label1.TabIndex = 16;
            label1.Text = "ARABA BİLGİ SİSTEMİ";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(756, 364);
            Controls.Add(label1);
            Controls.Add(btnPlakaGuncelle);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbla);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstArabalar);
            Controls.Add(groupBox1);
            Controls.Add(txtArabaId);
            Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.WindowText;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstArabalar;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtArabaId;
        private Label lbla;
        private RadioButton rdMarka;
        private RadioButton rdModel;
        private RadioButton rdMesafe;
        private RadioButton rdRenk;
        private GroupBox groupBox1;
        private TextBox txtArama;
        private Button btnAramaYap;
        private Button button1;
        private Button button2;
        private Button btnPlakaGuncelle;
        private Label label1;
    }
}
