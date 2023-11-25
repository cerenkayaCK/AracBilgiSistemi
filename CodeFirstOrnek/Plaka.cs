using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOrnek
{
    public class Plaka
    {
        public int Id { get; set; }
        public string PlakaKod { get; set; }
        public Araba araba { get; set; }
        public override string ToString()
        {
            return PlakaKod;
        }
    }
}
