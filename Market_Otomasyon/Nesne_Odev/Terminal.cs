using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Nesne_Odev
{
    public class Terminal:Dukkan
    {
        public int SeriNo { get;}
        private List<Satis> SatisListesi = new List<Satis>();
        public List<Urun> SiparisEdilenUrunler = new List<Urun>();
        public KasaGorevlisi Kasiyer = new KasaGorevlisi();
        
        
        public Terminal(int serino)
        {
            this.SeriNo = serino; 
        }
        public void KasaSatısBilgileriEkle(Satis s)//kasa görevlisi bilgileri giris ekranı yapılınca dukkana tasıncak
        {
            SatisListesi.Add(s);
        }
        public string HesapBilgileriListele()
        {
            string temp = "";
            foreach (Satis i in SatisListesi)
            {
                temp+="Musteri Adı:"+i.MusteriBilgileri.MusteriAd+"  "+"Musteri Adres:"+i.MusteriBilgileri.MusteriAdres+"  "+"Musteri Telefon:"+ i.MusteriBilgileri.MusteriTelefon+"  "+"Odeme Türü:"+i.OdemeTuru.OdemeTuru+"  " +"İşlem Tarihi"+ i.Tarih+"  "+"Tutar"+ i.TUTAR+"\n";
            }
            return temp;
        }
        public string SiparisEdilenUrunleriListele()
        {
            string temp = "";
            foreach (Urun i in SiparisEdilenUrunler)
            {
                temp += "urunkodu:" + i.UrunKodu + "urun tanim" + i.UrunTanim + "urun fiyat" + i.UrunFiyat + "siparis edilem urun miktari" + i.Miktar;
            }
            return temp;
        }
        public decimal TutarHesapla()
        {
            decimal tutar = 0;
            foreach (Urun i in SiparisEdilenUrunler)
            {
                tutar += (i.UrunFiyat * i.Miktar);
            }
            return tutar;
        }
    }
}
