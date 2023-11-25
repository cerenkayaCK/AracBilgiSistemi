using Microsoft.EntityFrameworkCore;

namespace CodeFirstOrnek
{
    public partial class Form1 : Form
    {
        UygulamaContextDb db;
        public Form1()
        {
            InitializeComponent();
            db = new UygulamaContextDb();
            Listele();
           


        }

        private void Listele() //veritabýnda bulunan arabalar listesini listele.
        {
           
            lstArabalar.DataSource = db.Arabalar.ToList();
            lstArabalar.SelectedIndex = db.Arabalar.Count() - 1;
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
            if (lstArabalar.SelectedItem != null)
            {
                Araba guncellenecekAraba = (Araba)lstArabalar.SelectedItem;

                ArabaBilgileriGuncelle form3 = new ArabaBilgileriGuncelle(guncellenecekAraba);
                form3.ShowDialog();
                Listele();
                lstArabalar.SelectedItem = (Araba)guncellenecekAraba;

            }
            else MessageBox.Show("guncellenecek araba bulunamadý");
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {

            if (rdMarka.Checked)
            {
                lstArabalar.DataSource = db.Arabalar.Where(x => x.Marka.Contains(txtArama.Text)).ToList();


            }
            if (rdModel.Checked)
            {

                lstArabalar.DataSource = db.Arabalar.Where(x => x.Model.Contains(txtArama.Text)).ToList();

            }
            if (rdMesafe.Checked)
            {
                lstArabalar.DataSource = db.Arabalar.Where(x => x.KatEttigiMesafe.ToString().Contains(txtArama.Text)).ToList();

            }
            if (rdRenk.Checked)
            {

                lstArabalar.DataSource = db.Arabalar.Where(x => x.Renk.Contains(txtArama.Text)).ToList();
            }

            //lstArabalar.Refresh();
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

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
