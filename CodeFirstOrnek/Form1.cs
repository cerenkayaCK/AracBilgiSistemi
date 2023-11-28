using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;

namespace CodeFirstOrnek
{
    public partial class Form1 : Form
    {
        UygulamaContextDb db;
        Muhendis guncellenecekMuhendis;
        public Form1()
        {
            InitializeComponent();
            db = new UygulamaContextDb();
            Listele();
            dgvArabalar.MultiSelect = false;
            cmbMuhendisler.DisplayMember = "AdSoyad";
            cmbMuhendisler.DataSource = db.Muhendisler.ToList();
            cmbMuhendisSilGuncelle.DataSource = db.Muhendisler.ToList();
        }

        private void Listele()
        {
            var arabalarMuhendisler = db.Arabalar
            .Include(a => a.MuhendisListesi)
            .Include(a => a.Sahip)
            .Include(a => a.Plaka)
            .ToList();

            dgvArabalar.DataSource = arabalarMuhendisler
                .Select(a => new
                {
                    ArabaID = a.Id,
                    Model = a.Model,
                    Marka = a.Marka,
                    SahipId = a.SahipId,
                    Sahip = a.Sahip,
                    Plaka = a.Plaka,
                    Renk = a.Renk,
                    Muhendisler = string.Join(", ", a.MuhendisListesi.Select(m => m.AdSoyad))
                })
                .ToList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ArabaEkle form2 = new ArabaEkle();
            form2.ShowDialog();
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int silinecekId = Convert.ToInt32(txtArabaId.Text); //silinecek olan arabanýn Id deðerini elde et.
                var silinecekAraba = db.Arabalar.FirstOrDefault(x => x.Id == silinecekId); //silinecek araba nesnesinin Id si silinecek Id ye eþit olmalýdýr.

                if (silinecekAraba == null)
                {
                    MessageBox.Show("silinecek Id ye ait araba bulunamadý");
                }
                else
                {
                    db.Arabalar.Remove(silinecekAraba);
                    db.SaveChanges();
                    Listele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("silinecek araba bulunamadý.");
                return;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvArabalar.SelectedRows.Count > 0)
            {
                int guncellenecekArabaId = (int)dgvArabalar.SelectedRows[0].Cells[0].Value;
                Araba araba = db.Arabalar.Find(guncellenecekArabaId);

                ArabaBilgileriGuncelle form3 = new ArabaBilgileriGuncelle(araba);
                form3.ShowDialog();
                Listele();

            }
            else
            {
                MessageBox.Show("Güncellenecek araba bulunamadý.");
            }
        }
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            if (rdMarka.Checked)
            {
                dgvArabalar.DataSource = db.Arabalar.Where(x => x.Marka.Contains(txtArama.Text)).ToList();

            }
            if (rdModel.Checked)
            {

                dgvArabalar.DataSource = db.Arabalar.Where(x => x.Model.Contains(txtArama.Text)).ToList();

            }
            if (rdMesafe.Checked)
            {
                dgvArabalar.DataSource = db.Arabalar.Where(x => x.KatEttigiMesafe.ToString().Contains(txtArama.Text)).ToList();

            }
            if (rdRenk.Checked)
            {

                dgvArabalar.DataSource = db.Arabalar.Where(x => x.Renk.Contains(txtArama.Text)).ToList();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PlakaEkleme plakaEkleme = new PlakaEkleme();
            plakaEkleme.ShowDialog();
        }
        private void btnPlakaGuncelle_Click(object sender, EventArgs e)
        {
            var plakaGuncellee = new PlakaGuncelle();
            plakaGuncellee.ShowDialog();
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int arabaid = 0;
            if (dgvArabalar.SelectedRows.Count > 0 && int.TryParse(dgvArabalar.SelectedRows[0].Cells["ArabaId"].Value.ToString(),out arabaid))
            {     
                Araba? araba = db.Arabalar.Find(arabaid);

                if (araba != null)
                {
                    if (cmbMuhendisler.SelectedItem != null)
                    {
                        var secilenMuhendis = (Muhendis)cmbMuhendisler.SelectedItem;
                        araba.MuhendisListesi.Add(secilenMuhendis);

                        int result = db.SaveChanges();

                        if (result > 0)
                        {
                            MessageBox.Show("Deðiþiklikler kaydedildi");
                            Listele();
                        }
                        else MessageBox.Show("Mühendis eklenemedi");
                    }
                    else MessageBox.Show("Mühendis seçmediniz");
                }
            }
            else MessageBox.Show("Araba seçmediniz");
        }
        private void btnMuhendisEkle_Click(object sender, EventArgs e)
        {
            Muhendis m = new Muhendis();
            m.AdSoyad = txtMuhendis.Text;
            db.Muhendisler.Add(m);
            int result = db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("Ekleme Baþarýlý");
                cmbMuhendisSilGuncelle.DataSource = db.Muhendisler.ToList();
            }
            else MessageBox.Show("Eklenemedi.");
            cmbMuhendisler.DisplayMember = "AdSoyad";
            cmbMuhendisler.DataSource = db.Muhendisler.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (cmbMuhendisSilGuncelle.SelectedItem != null)
            {
                var silinecekMuhendis = (Muhendis)cmbMuhendisSilGuncelle.SelectedItem;
                db.Muhendisler.Remove(silinecekMuhendis);
                int result = db.SaveChanges();
                if (result > 0) { MessageBox.Show("Mühendis Silindi"); cmbMuhendisSilGuncelle.DataSource = db.Muhendisler.ToList(); Listele(); cmbMuhendisler.DataSource = db.Muhendisler.ToList(); }
                else
                {
                    MessageBox.Show("Mühendis Silinemedi!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Silinecek Mühendisi Seçiniz.");
                return;
            }
        }
        private void btnMuhendisGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbMuhendisSilGuncelle.SelectedItem != null)
            {
                guncellenecekMuhendis.AdSoyad = txtMuhendis.Text;
                if (db.Entry(guncellenecekMuhendis).State == EntityState.Modified)
                {
                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Deðiþiklikler Kaydedildi");
                        cmbMuhendisler.DataSource = db.Muhendisler.ToList();
                        cmbMuhendisSilGuncelle.DataSource = db.Muhendisler.ToList();
                        Listele();
                    }
                    else
                    {
                        MessageBox.Show("Deðiþiklikler Kaydedilemedi !");
                        return;
                    }
                }
                else MessageBox.Show("herhangi bir deðiþiklik yapmadýnýz");
            }
            else
            {
                MessageBox.Show("Güncellemek istediðiniz Mühendisi Seçiniz.");
                return;
            }
        }

        private void cmbMuhendisSilGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            guncellenecekMuhendis = (Muhendis)cmbMuhendisSilGuncelle.SelectedItem;
            txtMuhendis.Text = guncellenecekMuhendis.AdSoyad;
        }
    }
}