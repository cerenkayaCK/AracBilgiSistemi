namespace CodeFirstOrnek
{
    partial class PlakaEkleme
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
            label1 = new Label();
            txtPlakaKod = new TextBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Plaka Kodu";
            // 
            // txtPlakaKod
            // 
            txtPlakaKod.Location = new Point(32, 50);
            txtPlakaKod.Name = "txtPlakaKod";
            txtPlakaKod.Size = new Size(167, 23);
            txtPlakaKod.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(32, 90);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(167, 32);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // PlakaEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 157);
            Controls.Add(btnEkle);
            Controls.Add(txtPlakaKod);
            Controls.Add(label1);
            Name = "PlakaEkleme";
            Text = "PlakaEkleme:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlakaKod;
        private Button btnEkle;
    }
}