using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Odev
{
    public class Satis
    {    
        public DateTime Tarih { get; set; }
        public Odeme OdemeTuru = new Odeme();
        public Musteri MusteriBilgileri = new Musteri();

        protected decimal tutar = 0;
        public decimal TUTAR
        {
            get
            {
                return tutar;
            }
        }
        public void TutarHesapla(decimal fiyat, int miktar)
        {
            tutar+=fiyat*miktar;
        }
    }
    }

