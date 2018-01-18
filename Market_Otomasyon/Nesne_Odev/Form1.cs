using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Nesne_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dukkan d = new Dukkan();
        Terminal t1 = new Terminal(1);
        public void btn_gorevligiris_Click(object sender, EventArgs e)
        {
            if (txt_perno.Text == "" || txt_peradsoy.Text == "")
            {
                MessageBox.Show("personel no ile adınızı soyadınızı giriniz");
            }
            else
            {
                list_tumsatisdokumu.Visible = false;
                btn_satislisteleme.Visible = true;
                btn_siparis.Visible = true;
                btn_gorevligiris.Enabled = false;
                btn_urungirisi.Visible = false;
                btn_urunguncelleme.Visible = false;
                btn_tumsatislar.Visible = false;
                t1.Kasiyer.PersonelAdiSoyadi =Convert.ToString(txt_peradsoy.Text.ToString());
                t1.Kasiyer.PersonelNo = Convert.ToInt32(txt_perno.Text.ToString());
                btn_cikis.Visible = true;
                txt_peradsoy.Clear();
                txt_perno.Clear();
            }
        }

        public void btn_siparis_Click(object sender, EventArgs e)
        {
            lbl_urunler.Visible = true;
            btn_ekle.Visible = true;
            btn_cikar.Visible = true;
            btn_satıs.Visible = true;
            list_SiparisEdilenUrunler.Visible = true;
            list_urunler.Visible = true;
            btn_urungirisi.Enabled = false;
            string urunler = " ";
            urunler = d.KatalogdakiUrunleriListele();
            string[] urunlerdizisi;
            urunlerdizisi = urunler.Split('\n');
            for (int i = 0; i < urunlerdizisi.Length - 1; i++)
            {
                list_urunler.Items.Add(urunlerdizisi[i].ToString());
            }
            btn_siparis.Enabled = false;
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string siparisdizisi;
            siparisdizisi = list_urunler.SelectedItem.ToString();
            siparisdizisi = siparisdizisi.Replace(siparisdizisi.Substring(47,14),string.Empty);
            siparisdizisi+="  "+"Urun adeti"+"  "+Convert.ToString(Interaction.InputBox("adeti girin", "adet giris", "", 100, 100));
            list_SiparisEdilenUrunler.Items.Add(siparisdizisi.ToString());
            
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            list_SiparisEdilenUrunler.Items.Remove(list_SiparisEdilenUrunler.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.Unvan = "SüperMarket";
            d.Adres = "7055 sokak no:63 gürpınar pınarbaşı bornova izmir";
            btn_cikis.Visible = false;
            btn_satislisteleme.Visible = false;
            btn_siparis.Visible = false;
            lbl_urunkodu.Visible = false;
            lbl_tanim.Visible = false;
            lbl_miktar.Visible = false;
            lbl_fiyat.Visible = false;
            lbl_gramaj.Visible = false;
            txt_urunfiyat.Visible = false;
            txt_urungramaj.Visible = false;
            txt_urunkodu.Visible = false;
            txt_urunmiktar.Visible = false;
            txt_uruntanim.Visible = false;
            btn_musterionay.Visible = false;
            lbl_urunler.Visible = false;
            btn_cikar.Visible = false;
            btn_ekle.Visible= false;
            btn_satıs.Visible = false;
            list_SiparisEdilenUrunler.Visible = false;
            list_urunler.Visible = false;
            lbl_adres.Visible = false;
            lbl_ad_soyad.Visible = false;
            lbl_Telefon.Visible = false;
            txt_adi.Visible = false;
            txt_adres.Visible = false;
            txt_tel.Visible = false;
            lbl_odemeturu.Visible = false;
            txt_odemeturu.Visible = false;
            btn_giristamamla.Visible = false;
            list_satisdokumu.Visible = false;
            list_tumsatisdokumu.Visible = false;
        }

        public void btn_satıs_Click(object sender, EventArgs e)
        {
            //siparisedilenurunler clasına veriler eklencek
            string dizi = "";
            for (int i = 0; i < list_SiparisEdilenUrunler.Items.Count; i++)
            {
                int pozisyon = 0;
                int u_kodu = 0;
                string u_tanim = "";
                decimal u_fiyat = 0;
                int u_miktar = 0;
                dizi = list_SiparisEdilenUrunler.Items[i].ToString();
                pozisyon=(dizi.IndexOf("Urunkodu:")+9);
                dizi=(dizi.Substring(pozisyon,2));
                u_kodu = Convert.ToInt32(dizi.ToString());
                dizi = list_SiparisEdilenUrunler.Items[i].ToString();
                pozisyon = (dizi.IndexOf("Urun tanım:") + 11);
                dizi = (dizi.Substring(pozisyon, 8));
                u_tanim = (dizi.ToString());
                dizi = list_SiparisEdilenUrunler.Items[i].ToString();
                pozisyon = (dizi.IndexOf("Urun fiyat:") + 11);
                dizi = (dizi.Substring(pozisyon, 3));
                u_fiyat = Convert.ToDecimal(dizi.ToString());
                dizi = list_SiparisEdilenUrunler.Items[i].ToString();
                pozisyon = (dizi.IndexOf("Urun adeti") + 10);
                dizi = (dizi.Substring(pozisyon, 3));
                u_miktar= Convert.ToInt32(dizi.ToString());
                Urun su = new Urun(u_kodu, u_tanim, u_fiyat);
                su.Miktar = u_miktar;
                t1.SiparisEdilenUrunler.Add(su);      
            }
            
            btn_ekle.Visible = false;
            btn_cikar.Visible = false;
            btn_satıs.Visible = false;
            list_urunler.Visible = false;
            lbl_urunler.Visible = false;
            txt_adi.Visible = true;
            txt_adres.Visible = true;
            txt_tel.Visible = true;
            lbl_ad_soyad.Visible = true;
            lbl_Telefon.Visible = true;
            lbl_adres.Visible = true;
            btn_musterionay.Visible = true;
            txt_odemeturu.Visible = true;
            lbl_odemeturu.Visible = true;
        }
         //sstring bulucu = "";
        private void btn_musterionay_Click(object sender, EventArgs e)
        {
            Satis s = new Satis();
            
            for (int i = 0; i <list_SiparisEdilenUrunler.Items.Count; i++)
            {
                int fiyat_pozisyon = 0;
                int miktar_pozisyon = 0;
                decimal fiyat_tutucu = 0;
                int miktar_tutucu = 0;
                string bulucu = list_SiparisEdilenUrunler.Items[i].ToString();
                fiyat_pozisyon = (bulucu.IndexOf("Urun fiyat:") + 11);
                fiyat_tutucu=Convert.ToDecimal(bulucu.Substring(fiyat_pozisyon, 3));
                miktar_pozisyon = (bulucu.IndexOf("Urun adeti") + 10);
                miktar_tutucu = Convert.ToInt32(bulucu.Substring(miktar_pozisyon, 3));
                s.TutarHesapla(fiyat_tutucu, miktar_tutucu);
                bulucu = "";
            }
            s.Tarih = DateTime.Now;
            s.MusteriBilgileri.MusteriAd = txt_adi.Text;
            s.MusteriBilgileri.MusteriTelefon = Convert.ToDouble(txt_tel.Text);
            s.MusteriBilgileri.MusteriAdres = txt_adres.Text;
            s.OdemeTuru.OdemeTuru = txt_odemeturu.Text;
            t1.KasaSatısBilgileriEkle(s);
            list_SiparisEdilenUrunler.Visible = false;
            lbl_adres.Visible = false;
            lbl_ad_soyad.Visible = false;
            lbl_Telefon.Visible = false;
            lbl_odemeturu.Visible = false;
            txt_adi.Visible = false;
            txt_adres.Visible = false;
            txt_odemeturu.Visible = false;
            txt_tel.Visible = false;
            btn_siparis.Enabled = true;
            btn_urungirisi.Enabled = true;
            list_SiparisEdilenUrunler.Items.Clear();
            list_urunler.Items.Clear();
            btn_musterionay.Visible = false;
            txt_adi.Clear();
            txt_adres.Clear();
            txt_odemeturu.Clear();
            txt_tel.Clear();
        }

        private void btn_urungirisi_Click(object sender, EventArgs e)
        {
            list_tumsatisdokumu.Visible = false;
            btn_siparis.Enabled = false;
            txt_urunfiyat.Visible = true;
            txt_urungramaj.Visible = true;
            txt_urunkodu.Visible = true;
            txt_urunmiktar.Visible = true;
            txt_uruntanim.Visible = true;
            lbl_urunkodu.Visible = true;
            lbl_fiyat.Visible = true;
            lbl_gramaj.Visible = true;
            lbl_miktar.Visible = true;
            lbl_tanim.Visible = true;
            btn_giristamamla.Visible = true;
        }

        private void btn_giristamamla_Click(object sender, EventArgs e)
        {
            UrunKatalogu u1 = new UrunKatalogu(Convert.ToInt32(txt_urunkodu.Text.ToString()),txt_uruntanim.Text.ToString(),Convert.ToInt32(txt_urunmiktar.Text.ToString()),Convert.ToDecimal(txt_urunfiyat.Text.ToString()),Convert.ToDecimal(txt_urungramaj.Text.ToString()));
            u1.BirimFiyat = (u1.UrunFiyat / u1.UrunGramaj) * 1;
            u1.BirimFiyat = Math.Round(u1.BirimFiyat, 2);
            d.KatalogdakiUrunler.Add(u1);
            DialogResult secilen=MessageBox.Show("Ürün eklemeye devam edecek misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(secilen==DialogResult.Yes)
            {
                txt_urunfiyat.Clear();
                txt_urungramaj.Clear();
                txt_urunkodu.Clear();
                txt_urunmiktar.Clear();
                txt_uruntanim.Clear();
            }
            else
            {
                lbl_urunkodu.Visible = false;
                lbl_tanim.Visible = false;
                lbl_miktar.Visible = false;
                lbl_fiyat.Visible = false;
                lbl_gramaj.Visible = false;
                txt_urunfiyat.Visible = false;
                txt_urungramaj.Visible = false;
                txt_urunkodu.Visible = false;
                txt_urunmiktar.Visible = false;
                txt_uruntanim.Visible = false;
                btn_giristamamla.Visible = false;
                btn_siparis.Enabled = true;
            }
        }

        
        private void btn_satislisteleme_Click(object sender, EventArgs e)
        {
            list_satisdokumu.Visible = true;
            string[] satis_dizisi = t1.HesapBilgileriListele().Split('\n');
            for (int i = 0; i < satis_dizisi.Length; i++)
            {
                list_satisdokumu.Items.Add(satis_dizisi[i].ToString());
            }
            for (int j = 0; j <satis_dizisi.Length; j++)
            {
                satis_dizisi[0] = "";
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            btn_satislisteleme.Visible = false;
            btn_siparis.Visible = false;
            btn_cikis.Visible = false;
            btn_gorevligiris.Enabled = true;
            btn_urungirisi.Visible = true;
            btn_urunguncelleme.Visible = true;
            btn_tumsatislar.Visible = true;
            list_satisdokumu.Visible = false;
            d.KasaSatislariEkle(t1);
            list_satisdokumu.Items.Clear();
            
        }

        private void btn_tumsatislar_Click(object sender, EventArgs e)
        {
            list_tumsatisdokumu.Visible = true;
            string[] tumsatis_dizisi = d.TumSatislariListele().Split('\n');
            for (int i = 0; i < tumsatis_dizisi.Length; i++)
            {
                list_tumsatisdokumu.Items.Add(tumsatis_dizisi[i].ToString());
            }
            for (int j = 0; j < tumsatis_dizisi.Length; j++)
            {
                tumsatis_dizisi[j] = "";
            }
        
        }
    }
}
