using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstOrnek
{
    public partial class PlakaGuncelle : Form
    {
        UygulamaContextDb db = new UygulamaContextDb();

        private Plaka guncellenecekPlaka;
        public PlakaGuncelle()
        {
            InitializeComponent();
            cboPlakalar.SelectedIndex = -1;
            cboPlakalar.DataSource = db.Plakalar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string yeniPlakaKod = txtGuncelle.Text.Trim();

                // Eğer plaka metni değişmediyse güncelleme işlemini yapma..
                if (guncellenecekPlaka.PlakaKod != yeniPlakaKod)
                {
                    guncellenecekPlaka.PlakaKod = yeniPlakaKod;
                    db.Plakalar.Entry(guncellenecekPlaka).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Plaka Güncellendi");

                }
                else
                {
                    MessageBox.Show("Plaka metni değişmedi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void cboPlakalar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboPlakalar.SelectedItem != null)
            {
                Plaka secilenPlaka = (Plaka)cboPlakalar.SelectedItem;
                guncellenecekPlaka = secilenPlaka;
                txtGuncelle.Text = guncellenecekPlaka.PlakaKod;


            }
            else
            {
                MessageBox.Show("güncellenecek Plaka Kodunu Seçiniz.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
