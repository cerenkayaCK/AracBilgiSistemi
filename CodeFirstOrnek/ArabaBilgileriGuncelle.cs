using CodeFirstOrnek;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeFirstOrnek
{
    public partial class ArabaBilgileriGuncelle : Form
    {
        UygulamaContextDb db;

        private Araba guncellenecekaraba;
        public ArabaBilgileriGuncelle(Araba araba)
        {
            InitializeComponent();
            db = new UygulamaContextDb();
            guncellenecekaraba = araba;
            
            txtMarka.Text = araba.Marka;
            txtMesafe.Text = araba.KatEttigiMesafe.ToString();
            txtModel.Text = araba.Model;
            txtRenk.Text = araba.Renk;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncellenecekaraba.Marka = txtMarka.Text;
            guncellenecekaraba.KatEttigiMesafe = Convert.ToSingle(txtMesafe.Text);
            guncellenecekaraba.Model = txtModel.Text;
            guncellenecekaraba.Renk = txtRenk.Text;
            db.Entry(guncellenecekaraba).State = EntityState.Modified;
            db.SaveChanges();            
            this.Close();
        }
    }
}


//Araba arama bölümü yazınız. (Arama textbox'ı olsun. Sonra Marka, Model Yılı, Mesafe ve Renk olacak şekilde
//4 tane radio button ekleyiniz. Bu kriterlerden hangisi seçildiyse arama textbox'ına yazılan kelimeyi o kriterde arayıp, bulduklarını
//listelesin. (Aratılan kelimeyi İÇERECEK ŞEKİLDE arasın)