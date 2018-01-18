using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Odev
{
    public class Urun : UrunTanimi
    {
        public Urun(int urunkodu, string uruntanim, decimal fiyat) : base(urunkodu, uruntanim, fiyat)
        {
        }

        public override int Miktar
        {
            get
            {
                return base.Miktar;
            }
        }
    }
}
