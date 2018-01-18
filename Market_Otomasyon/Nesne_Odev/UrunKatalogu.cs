using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Odev
{
    public class UrunKatalogu : UrunTanimi
    {
        public UrunKatalogu(int urunkodu, string uruntanim, int miktar, decimal fiyat, decimal gramaj) : base(urunkodu, uruntanim, miktar, fiyat, gramaj)
        {
        }
        public decimal BirimFiyat { get; set; }
    }
}
