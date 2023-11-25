namespace CodeFirstOrnek
{
    partial class YeniKisiOlusturmaFormu
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
            txtAdSoyad = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(29, 42);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(160, 23);
            txtAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            // 
            // button1
            // 
            button1.Location = new Point(29, 83);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 3;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YeniKisiOlusturmaFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 133);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Name = "YeniKisiOlusturmaFormu";
            Text = "YeniKisiOlusturmaFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private Label label1;
        private Button button1;
    }
}