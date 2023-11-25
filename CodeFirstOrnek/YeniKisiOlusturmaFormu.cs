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
    public partial class YeniKisiOlusturmaFormu : Form
    {
        UygulamaContextDb db;
        public YeniKisiOlusturmaFormu()
        {
            InitializeComponent();
            db=new UygulamaContextDb();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Sahip YeniSahip = new Sahip();
            YeniSahip.TamAd = txtAdSoyad.Text;
            db.Sahipler.Add(YeniSahip);
           
            await db.SaveChangesAsync();

             MessageBox.Show("Kullanıcı ID'si: "+YeniSahip.Id+YeniSahip.TamAd);
            
        }
    }
}
