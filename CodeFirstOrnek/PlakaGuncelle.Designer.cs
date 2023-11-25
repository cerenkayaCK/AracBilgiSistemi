namespace CodeFirstOrnek
{
    partial class PlakaGuncelle
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
            txtGuncelle = new TextBox();
            button1 = new Button();
            cboPlakalar = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtGuncelle
            // 
            txtGuncelle.Location = new Point(28, 70);
            txtGuncelle.Name = "txtGuncelle";
            txtGuncelle.Size = new Size(164, 23);
            txtGuncelle.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(28, 111);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 2;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboPlakalar
            // 
            cboPlakalar.DisplayMember = "PlakaKod";
            cboPlakalar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlakalar.FormattingEnabled = true;
            cboPlakalar.Location = new Point(28, 41);
            cboPlakalar.Name = "cboPlakalar";
            cboPlakalar.Size = new Size(164, 23);
            cboPlakalar.TabIndex = 3;
            cboPlakalar.SelectedIndexChanged += cboPlakalar_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 23);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Plaka Kodu Seçiniz\r\n";
            // 
            // button2
            // 
            button2.Location = new Point(118, 111);
            button2.Name = "button2";
            button2.Size = new Size(71, 23);
            button2.TabIndex = 5;
            button2.Text = "İPTAL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PlakaGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 167);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(cboPlakalar);
            Controls.Add(button1);
            Controls.Add(txtGuncelle);
            Name = "PlakaGuncelle";
            Text = "PlakaGuncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtGuncelle;
        private Button button1;
        private ComboBox cboPlakalar;
        private Label label2;
        private Button button2;
    }
}