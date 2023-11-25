using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOrnek
{
    public class Sahip
    {
        public int Id { get; set; }

        public string TamAd { get; set; }
        public List<Araba> KisininArabalari{ get; set; } = new List<Araba>();

        public override string ToString()
        {
            return TamAd;
        }
    }
}
