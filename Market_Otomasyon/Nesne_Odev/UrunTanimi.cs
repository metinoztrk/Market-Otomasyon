using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Odev
{
    public abstract class UrunTanimi : SatisKalemi
    {
        public int UrunKodu { get; set; }
        public string UrunTanim { get; set; }
        public decimal UrunFiyat { get; set; }
        public decimal UrunGramaj { get; set; }
        public UrunTanimi(int urunkodu, string uruntanim, int miktar, decimal fiyat, decimal gramaj)
        {
            this.UrunKodu = urunkodu;
            this.UrunTanim = uruntanim;
            this.UrunFiyat = fiyat;
            this.Miktar = miktar;
            this.UrunGramaj = gramaj;
        }
        public UrunTanimi(int urunkodu, string uruntanim, decimal fiyat)

        {
            this.UrunFiyat = fiyat;
            this.UrunKodu = urunkodu;
            this.UrunTanim = uruntanim;
        }

    }
}
