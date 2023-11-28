using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOrnek
{
    public class Muhendis
    {
        public int Id { get; set; } 

        public string AdSoyad { get; set; } = null!;

        public virtual List<Araba> Arabalar { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
