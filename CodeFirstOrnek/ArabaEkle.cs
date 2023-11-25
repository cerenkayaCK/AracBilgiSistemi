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
    public partial class ArabaEkle : Form
    {
        UygulamaContextDb db = new UygulamaContextDb();
        public ArabaEkle()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {

            int girilenId = Convert.ToInt32(txtSahipId.Text);
            var sahip = db.Sahipler.FirstOrDefault(x => x.Id == girilenId);

            if (sahip != null)
            {
                Araba araba = new Araba();
                araba.Model = txtModel.Text;
                araba.Marka = txtMarka.Text;
                araba.Renk = txtRenk.Text;
                araba.SahipId = girilenId;

                if (cmbPlakalar.SelectedItem !=null) 
                { 
                Plaka secilenPlaka = (Plaka)cmbPlakalar.SelectedItem;
                araba.Plaka = secilenPlaka;
                }

                else
                {
                    MessageBox.Show("plaka seçmediniz!");
                    return;
                }

                araba.KatEttigiMesafe = Convert.ToSingle(txtMesafe.Text);
                araba.Sahip = sahip;
                db.Arabalar.Add(araba);


                db.SaveChanges();

                MessageBox.Show("Araba Bilgileri Eklendi");

                this.Close();



            }
            else
            {
                MessageBox.Show("Id bulunamadı. Yeni üyelik oluşturunuz.");
                return;

            }


            //if (db.Sahipler.Find(girilenId)!=null)
            //{
            //    araba.SahipId = Convert.ToInt32(txtSahipId.Text);
            //}
            //else MessageBox.Show("Id bulunamadı. yeni üyelik oluşturunuz.");



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            cmbPlakalar.DataSource = db.Plakalar.Where(x => x.araba==null).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniKisiOlusturmaFormu yeniKisiForm = new();
            yeniKisiForm.ShowDialog();
        }
    }
}
