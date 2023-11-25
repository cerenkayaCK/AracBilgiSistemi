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
    public partial class PlakaEkleme : Form
    {
        UygulamaContextDb db = new UygulamaContextDb();
        public PlakaEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Plaka plaka = new Plaka();
            plaka.PlakaKod = txtPlakaKod.Text;
            db.Plakalar.Add(plaka);
            db.SaveChanges();
            this.Close();
        }
    }
}
