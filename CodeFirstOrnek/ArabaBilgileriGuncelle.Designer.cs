namespace CodeFirstOrnek
{
    partial class ArabaBilgileriGuncelle
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
            grpEkle = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            txtRenk = new TextBox();
            label3 = new Label();
            txtMesafe = new TextBox();
            txtMarka = new TextBox();
            label1 = new Label();
            txtModel = new TextBox();
            btnGuncelle = new Button();
            grpEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grpEkle
            // 
            grpEkle.Controls.Add(label4);
            grpEkle.Controls.Add(label2);
            grpEkle.Controls.Add(txtRenk);
            grpEkle.Controls.Add(label3);
            grpEkle.Controls.Add(txtMesafe);
            grpEkle.Controls.Add(txtMarka);
            grpEkle.Controls.Add(label1);
            grpEkle.Controls.Add(txtModel);
            grpEkle.Location = new Point(38, 28);
            grpEkle.Name = "grpEkle";
            grpEkle.Size = new Size(248, 198);
            grpEkle.TabIndex = 12;
            grpEkle.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 108);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "renk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "marka";
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(130, 126);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(100, 23);
            txtRenk.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 44);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "mesafe";
            // 
            // txtMesafe
            // 
            txtMesafe.Location = new Point(134, 62);
            txtMesafe.Name = "txtMesafe";
            txtMesafe.Size = new Size(100, 23);
            txtMesafe.TabIndex = 2;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(6, 62);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(100, 23);
            txtMarka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 108);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(8, 126);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(38, 241);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(248, 28);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // ArabaBilgileriGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 300);
            Controls.Add(btnGuncelle);
            Controls.Add(grpEkle);
            Name = "ArabaBilgileriGuncelle";
            Text = "Araba Bilgileri Güncelleme";
            grpEkle.ResumeLayout(false);
            grpEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEkle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRenk;
        private TextBox txtMesafe;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Button btnGuncelle;
    }
}