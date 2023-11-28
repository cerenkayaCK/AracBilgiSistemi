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
            button3 = new Button();
            cmbMuhendisler = new ComboBox();
            groupBox2 = new GroupBox();
            btnMuhendisGuncelle = new Button();
            cmbMuhendisSilGuncelle = new ComboBox();
            btnMuhendisEkle = new Button();
            button4 = new Button();
            label2 = new Label();
            txtMuhendis = new TextBox();
            dgvArabalar = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkGray;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(590, 33);
            btnEkle.Margin = new Padding(4, 2, 4, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(147, 74);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Araba Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkGray;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(92, 300);
            btnSil.Margin = new Padding(4, 2, 4, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 70);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkGray;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(402, 33);
            btnGuncelle.Margin = new Padding(4, 2, 4, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(190, 74);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Araba Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtArabaId
            // 
            txtArabaId.BackColor = SystemColors.Menu;
            txtArabaId.Location = new Point(13, 333);
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
            lbla.Location = new Point(17, 319);
            lbla.Margin = new Padding(4, 0, 4, 0);
            lbla.Name = "lbla";
            lbla.Size = new Size(49, 11);
            lbla.TabIndex = 4;
            lbla.Text = "ArabaId : ";
            // 
            // rdMarka
            // 
            rdMarka.AutoSize = true;
            rdMarka.Location = new Point(26, 117);
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
            rdModel.Location = new Point(25, 71);
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
            rdMesafe.Location = new Point(115, 71);
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
            rdRenk.Location = new Point(115, 117);
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
            groupBox1.Location = new Point(509, 111);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(226, 259);
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
            btnAramaYap.Size = new Size(201, 37);
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
            txtArama.Size = new Size(201, 32);
            txtArama.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(202, 300);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(192, 70);
            button1.TabIndex = 11;
            button1.Text = "ARABALARI GÖSTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(402, 107);
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
            btnPlakaGuncelle.Location = new Point(402, 240);
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
            label1.Location = new Point(7, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 10);
            label1.TabIndex = 16;
            label1.Text = "ARABA BİLGİ SİSTEMİ";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(745, 314);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(178, 47);
            button3.TabIndex = 17;
            button3.Text = "Mühendis Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cmbMuhendisler
            // 
            cmbMuhendisler.BackColor = SystemColors.Menu;
            cmbMuhendisler.FormattingEnabled = true;
            cmbMuhendisler.Location = new Point(745, 287);
            cmbMuhendisler.Name = "cmbMuhendisler";
            cmbMuhendisler.Size = new Size(178, 23);
            cmbMuhendisler.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMuhendisGuncelle);
            groupBox2.Controls.Add(cmbMuhendisSilGuncelle);
            groupBox2.Controls.Add(btnMuhendisEkle);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMuhendis);
            groupBox2.Location = new Point(745, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(178, 248);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mühendis Bilgisi";
            // 
            // btnMuhendisGuncelle
            // 
            btnMuhendisGuncelle.BackColor = Color.DarkGray;
            btnMuhendisGuncelle.ForeColor = Color.White;
            btnMuhendisGuncelle.Location = new Point(91, 168);
            btnMuhendisGuncelle.Margin = new Padding(4, 2, 4, 2);
            btnMuhendisGuncelle.Name = "btnMuhendisGuncelle";
            btnMuhendisGuncelle.Size = new Size(82, 34);
            btnMuhendisGuncelle.TabIndex = 12;
            btnMuhendisGuncelle.Text = "Güncelle";
            btnMuhendisGuncelle.UseVisualStyleBackColor = false;
            btnMuhendisGuncelle.Click += btnMuhendisGuncelle_Click;
            // 
            // cmbMuhendisSilGuncelle
            // 
            cmbMuhendisSilGuncelle.BackColor = SystemColors.Menu;
            cmbMuhendisSilGuncelle.FormattingEnabled = true;
            cmbMuhendisSilGuncelle.Location = new Point(16, 130);
            cmbMuhendisSilGuncelle.Name = "cmbMuhendisSilGuncelle";
            cmbMuhendisSilGuncelle.Size = new Size(155, 23);
            cmbMuhendisSilGuncelle.TabIndex = 22;
            cmbMuhendisSilGuncelle.SelectedIndexChanged += cmbMuhendisSilGuncelle_SelectedIndexChanged;
            // 
            // btnMuhendisEkle
            // 
            btnMuhendisEkle.BackColor = Color.DarkGray;
            btnMuhendisEkle.ForeColor = Color.Transparent;
            btnMuhendisEkle.Location = new Point(16, 84);
            btnMuhendisEkle.Name = "btnMuhendisEkle";
            btnMuhendisEkle.Size = new Size(158, 29);
            btnMuhendisEkle.TabIndex = 12;
            btnMuhendisEkle.Text = "EKLE";
            btnMuhendisEkle.UseVisualStyleBackColor = false;
            btnMuhendisEkle.Click += btnMuhendisEkle_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.ForeColor = Color.White;
            button4.Location = new Point(16, 167);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(76, 35);
            button4.TabIndex = 21;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // txtMuhendis
            // 
            txtMuhendis.BackColor = SystemColors.Menu;
            txtMuhendis.ForeColor = SystemColors.InfoText;
            txtMuhendis.Location = new Point(16, 53);
            txtMuhendis.Name = "txtMuhendis";
            txtMuhendis.Size = new Size(155, 23);
            txtMuhendis.TabIndex = 0;
            // 
            // dgvArabalar
            // 
            dgvArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabalar.Location = new Point(12, 33);
            dgvArabalar.MultiSelect = false;
            dgvArabalar.Name = "dgvArabalar";
            dgvArabalar.Size = new Size(382, 262);
            dgvArabalar.TabIndex = 20;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(941, 396);
            Controls.Add(dgvArabalar);
            Controls.Add(cmbMuhendisler);
            Controls.Add(button3);
            Controls.Add(btnPlakaGuncelle);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbla);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Controls.Add(txtArabaId);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.WindowText;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button button3;
        private ComboBox cmbMuhendisler;
        private GroupBox groupBox2;
        private Button btnMuhendisEkle;
        private Label label2;
        private TextBox txtMuhendis;
        private DataGridView dgvArabalar;
        private Button btnMuhendisGuncelle;
        private Button button4;
        private ComboBox cmbMuhendisSilGuncelle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
