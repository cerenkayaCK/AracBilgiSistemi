using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOrnek
{
    public class Araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }

        public string Model { get; set; }

        public float KatEttigiMesafe { get; set; }

        public string Renk { get; set; }

        public int PlakaId { get; set; }

        public Plaka Plaka { get; set; }
        
        public int SahipId { get; set; }

        public Sahip Sahip { get; set; }


        public override string ToString()
        {
            return Id + "-" + Marka + " " + Model+"   "+KatEttigiMesafe+"  "+Renk+"  "+"plakaId: "+PlakaId+" Araç Sahibi: "+ SahipId;
        }
    }
}
