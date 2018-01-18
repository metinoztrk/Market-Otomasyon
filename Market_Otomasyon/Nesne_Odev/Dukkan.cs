using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Odev
{
    public class Dukkan
    {
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public List<UrunKatalogu> KatalogdakiUrunler = new List<UrunKatalogu>();
        public List<Terminal> Terminaller = new List<Terminal>();
        public HesapDefteri HesapDokumu = new HesapDefteri ();

        public Terminal t { get; set; }
        public void KasaSatislariEkle(Terminal t)
        {
            Terminaller.Add(t);
        }
        public string TumSatislariListele()
        {
            string temp ="";
            foreach (Terminal i in Terminaller)
            {
                temp +="Personel ad:"+i.Kasiyer.PersonelAdiSoyadi+"Personel no:"+ i.Kasiyer.PersonelNo +"Kasa no:"+ i.SeriNo+"\n"+ i.HesapBilgileriListele();
            }
            return temp;
        }
        public string KatalogdakiUrunleriListele()
        {
            string temp = "";
            foreach (UrunKatalogu i in KatalogdakiUrunler)
            {
                temp += "Urunkodu:" + i.UrunKodu + "  " + "Urun tanım:" + i.UrunTanim + "  " + "Urun fiyat:" + i.UrunFiyat + "  " + "Urun stogu:" + i.Miktar +"  "+ "Urun birim fiyati:" + i.BirimFiyat + Environment.NewLine;
            }
            return temp;
        }
    }
}
