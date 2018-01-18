namespace Nesne_Odev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_urunler = new System.Windows.Forms.ListBox();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.lbl_urunler = new System.Windows.Forms.Label();
            this.list_SiparisEdilenUrunler = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_satıs = new System.Windows.Forms.Button();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.btn_musterionay = new System.Windows.Forms.Button();
            this.lbl_odemeturu = new System.Windows.Forms.Label();
            this.txt_odemeturu = new System.Windows.Forms.TextBox();
            this.btn_urungirisi = new System.Windows.Forms.Button();
            this.txt_urunfiyat = new System.Windows.Forms.TextBox();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_miktar = new System.Windows.Forms.Label();
            this.txt_urunmiktar = new System.Windows.Forms.TextBox();
            this.lbl_tanim = new System.Windows.Forms.Label();
            this.txt_uruntanim = new System.Windows.Forms.TextBox();
            this.lbl_urunkodu = new System.Windows.Forms.Label();
            this.txt_urunkodu = new System.Windows.Forms.TextBox();
            this.txt_urungramaj = new System.Windows.Forms.TextBox();
            this.lbl_gramaj = new System.Windows.Forms.Label();
            this.btn_giristamamla = new System.Windows.Forms.Button();
            this.btn_urunguncelleme = new System.Windows.Forms.Button();
            this.btn_satislisteleme = new System.Windows.Forms.Button();
            this.btn_gorevligiris = new System.Windows.Forms.Button();
            this.list_satisdokumu = new System.Windows.Forms.ListBox();
            this.btn_tumsatislar = new System.Windows.Forms.Button();
            this.lbl_personelno = new System.Windows.Forms.Label();
            this.lbl_personeladsoyad = new System.Windows.Forms.Label();
            this.txt_perno = new System.Windows.Forms.TextBox();
            this.txt_peradsoy = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.list_tumsatisdokumu = new System.Windows.Forms.ListBox();
            this.txt_terminalno = new System.Windows.Forms.TextBox();
            this.lbl_terno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_urunler
            // 
            this.list_urunler.FormattingEnabled = true;
            this.list_urunler.ItemHeight = 20;
            this.list_urunler.Location = new System.Drawing.Point(12, 188);
            this.list_urunler.Name = "list_urunler";
            this.list_urunler.Size = new System.Drawing.Size(614, 284);
            this.list_urunler.TabIndex = 0;
            // 
            // btn_siparis
            // 
            this.btn_siparis.Location = new System.Drawing.Point(555, 125);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(161, 59);
            this.btn_siparis.TabIndex = 1;
            this.btn_siparis.Text = "Urun Siparis Etme";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // lbl_urunler
            // 
            this.lbl_urunler.AutoSize = true;
            this.lbl_urunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunler.Location = new System.Drawing.Point(125, 145);
            this.lbl_urunler.Name = "lbl_urunler";
            this.lbl_urunler.Size = new System.Drawing.Size(177, 37);
            this.lbl_urunler.TabIndex = 2;
            this.lbl_urunler.Text = "ÜRÜNLER";
            // 
            // list_SiparisEdilenUrunler
            // 
            this.list_SiparisEdilenUrunler.FormattingEnabled = true;
            this.list_SiparisEdilenUrunler.ItemHeight = 20;
            this.list_SiparisEdilenUrunler.Location = new System.Drawing.Point(636, 188);
            this.list_SiparisEdilenUrunler.Name = "list_SiparisEdilenUrunler";
            this.list_SiparisEdilenUrunler.Size = new System.Drawing.Size(622, 284);
            this.list_SiparisEdilenUrunler.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(555, 478);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 41);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(636, 478);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(75, 41);
            this.btn_cikar.TabIndex = 5;
            this.btn_cikar.Text = "Cıkar";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_satıs
            // 
            this.btn_satıs.Location = new System.Drawing.Point(1082, 487);
            this.btn_satıs.Name = "btn_satıs";
            this.btn_satıs.Size = new System.Drawing.Size(176, 32);
            this.btn_satıs.TabIndex = 6;
            this.btn_satıs.Text = "Satıs Tamamlama";
            this.btn_satıs.UseVisualStyleBackColor = true;
            this.btn_satıs.Click += new System.EventHandler(this.btn_satıs_Click);
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(172, 224);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(200, 26);
            this.txt_adi.TabIndex = 7;
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Location = new System.Drawing.Point(26, 230);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(140, 20);
            this.lbl_ad_soyad.TabIndex = 8;
            this.lbl_ad_soyad.Text = "Musteri Adı Soyadı";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(26, 259);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(118, 20);
            this.lbl_Telefon.TabIndex = 10;
            this.lbl_Telefon.Text = "Musteri Telefon";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(172, 253);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(200, 26);
            this.txt_tel.TabIndex = 9;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(26, 288);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(107, 20);
            this.lbl_adres.TabIndex = 12;
            this.lbl_adres.Text = "Musteri Adres";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(172, 285);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(200, 124);
            this.txt_adres.TabIndex = 11;
            // 
            // btn_musterionay
            // 
            this.btn_musterionay.Location = new System.Drawing.Point(132, 478);
            this.btn_musterionay.Name = "btn_musterionay";
            this.btn_musterionay.Size = new System.Drawing.Size(240, 37);
            this.btn_musterionay.TabIndex = 13;
            this.btn_musterionay.Text = "Musteri Bilgileri Onaylama";
            this.btn_musterionay.UseVisualStyleBackColor = true;
            this.btn_musterionay.Click += new System.EventHandler(this.btn_musterionay_Click);
            // 
            // lbl_odemeturu
            // 
            this.lbl_odemeturu.AutoSize = true;
            this.lbl_odemeturu.Location = new System.Drawing.Point(26, 428);
            this.lbl_odemeturu.Name = "lbl_odemeturu";
            this.lbl_odemeturu.Size = new System.Drawing.Size(97, 20);
            this.lbl_odemeturu.TabIndex = 14;
            this.lbl_odemeturu.Text = "Odeme Turu";
            // 
            // txt_odemeturu
            // 
            this.txt_odemeturu.Location = new System.Drawing.Point(172, 428);
            this.txt_odemeturu.Name = "txt_odemeturu";
            this.txt_odemeturu.Size = new System.Drawing.Size(200, 26);
            this.txt_odemeturu.TabIndex = 15;
            // 
            // btn_urungirisi
            // 
            this.btn_urungirisi.Location = new System.Drawing.Point(555, 22);
            this.btn_urungirisi.Name = "btn_urungirisi";
            this.btn_urungirisi.Size = new System.Drawing.Size(161, 59);
            this.btn_urungirisi.TabIndex = 16;
            this.btn_urungirisi.Text = "Urun Girişi";
            this.btn_urungirisi.UseVisualStyleBackColor = true;
            this.btn_urungirisi.Click += new System.EventHandler(this.btn_urungirisi_Click);
            // 
            // txt_urunfiyat
            // 
            this.txt_urunfiyat.Location = new System.Drawing.Point(555, 316);
            this.txt_urunfiyat.Name = "txt_urunfiyat";
            this.txt_urunfiyat.Size = new System.Drawing.Size(200, 26);
            this.txt_urunfiyat.TabIndex = 24;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(409, 319);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(82, 20);
            this.lbl_fiyat.TabIndex = 23;
            this.lbl_fiyat.Text = "Urun Fiyat";
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.AutoSize = true;
            this.lbl_miktar.Location = new System.Drawing.Point(409, 288);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(91, 20);
            this.lbl_miktar.TabIndex = 22;
            this.lbl_miktar.Text = "Urun Miktar";
            // 
            // txt_urunmiktar
            // 
            this.txt_urunmiktar.Location = new System.Drawing.Point(555, 285);
            this.txt_urunmiktar.Name = "txt_urunmiktar";
            this.txt_urunmiktar.Size = new System.Drawing.Size(200, 26);
            this.txt_urunmiktar.TabIndex = 21;
            // 
            // lbl_tanim
            // 
            this.lbl_tanim.AutoSize = true;
            this.lbl_tanim.Location = new System.Drawing.Point(409, 259);
            this.lbl_tanim.Name = "lbl_tanim";
            this.lbl_tanim.Size = new System.Drawing.Size(91, 20);
            this.lbl_tanim.TabIndex = 20;
            this.lbl_tanim.Text = "Urun Tanım";
            // 
            // txt_uruntanim
            // 
            this.txt_uruntanim.Location = new System.Drawing.Point(555, 253);
            this.txt_uruntanim.Name = "txt_uruntanim";
            this.txt_uruntanim.Size = new System.Drawing.Size(200, 26);
            this.txt_uruntanim.TabIndex = 19;
            // 
            // lbl_urunkodu
            // 
            this.lbl_urunkodu.AutoSize = true;
            this.lbl_urunkodu.Location = new System.Drawing.Point(409, 230);
            this.lbl_urunkodu.Name = "lbl_urunkodu";
            this.lbl_urunkodu.Size = new System.Drawing.Size(85, 20);
            this.lbl_urunkodu.TabIndex = 18;
            this.lbl_urunkodu.Text = "Urun Kodu";
            // 
            // txt_urunkodu
            // 
            this.txt_urunkodu.Location = new System.Drawing.Point(555, 224);
            this.txt_urunkodu.Name = "txt_urunkodu";
            this.txt_urunkodu.Size = new System.Drawing.Size(200, 26);
            this.txt_urunkodu.TabIndex = 17;
            // 
            // txt_urungramaj
            // 
            this.txt_urungramaj.Location = new System.Drawing.Point(555, 348);
            this.txt_urungramaj.Name = "txt_urungramaj";
            this.txt_urungramaj.Size = new System.Drawing.Size(200, 26);
            this.txt_urungramaj.TabIndex = 26;
            // 
            // lbl_gramaj
            // 
            this.lbl_gramaj.AutoSize = true;
            this.lbl_gramaj.Location = new System.Drawing.Point(409, 351);
            this.lbl_gramaj.Name = "lbl_gramaj";
            this.lbl_gramaj.Size = new System.Drawing.Size(100, 20);
            this.lbl_gramaj.TabIndex = 25;
            this.lbl_gramaj.Text = "Urun Gramaj";
            // 
            // btn_giristamamla
            // 
            this.btn_giristamamla.Location = new System.Drawing.Point(555, 395);
            this.btn_giristamamla.Name = "btn_giristamamla";
            this.btn_giristamamla.Size = new System.Drawing.Size(200, 53);
            this.btn_giristamamla.TabIndex = 27;
            this.btn_giristamamla.Text = "Urun Girişi Tamamla";
            this.btn_giristamamla.UseVisualStyleBackColor = true;
            this.btn_giristamamla.Click += new System.EventHandler(this.btn_giristamamla_Click);
            // 
            // btn_urunguncelleme
            // 
            this.btn_urunguncelleme.Location = new System.Drawing.Point(786, 22);
            this.btn_urunguncelleme.Name = "btn_urunguncelleme";
            this.btn_urunguncelleme.Size = new System.Drawing.Size(161, 59);
            this.btn_urunguncelleme.TabIndex = 28;
            this.btn_urunguncelleme.Text = "Urun Güncelleme";
            this.btn_urunguncelleme.UseVisualStyleBackColor = true;
            // 
            // btn_satislisteleme
            // 
            this.btn_satislisteleme.Location = new System.Drawing.Point(786, 123);
            this.btn_satislisteleme.Name = "btn_satislisteleme";
            this.btn_satislisteleme.Size = new System.Drawing.Size(161, 59);
            this.btn_satislisteleme.TabIndex = 29;
            this.btn_satislisteleme.Text = "Satislari Listeleme";
            this.btn_satislisteleme.UseVisualStyleBackColor = true;
            this.btn_satislisteleme.Click += new System.EventHandler(this.btn_satislisteleme_Click);
            // 
            // btn_gorevligiris
            // 
            this.btn_gorevligiris.Location = new System.Drawing.Point(330, 22);
            this.btn_gorevligiris.Name = "btn_gorevligiris";
            this.btn_gorevligiris.Size = new System.Drawing.Size(161, 59);
            this.btn_gorevligiris.TabIndex = 30;
            this.btn_gorevligiris.Text = "Kasiyer Giriş";
            this.btn_gorevligiris.UseVisualStyleBackColor = true;
            this.btn_gorevligiris.Click += new System.EventHandler(this.btn_gorevligiris_Click);
            // 
            // list_satisdokumu
            // 
            this.list_satisdokumu.FormattingEnabled = true;
            this.list_satisdokumu.ItemHeight = 20;
            this.list_satisdokumu.Location = new System.Drawing.Point(12, 188);
            this.list_satisdokumu.Name = "list_satisdokumu";
            this.list_satisdokumu.Size = new System.Drawing.Size(1246, 284);
            this.list_satisdokumu.TabIndex = 31;
            // 
            // btn_tumsatislar
            // 
            this.btn_tumsatislar.Location = new System.Drawing.Point(1014, 22);
            this.btn_tumsatislar.Name = "btn_tumsatislar";
            this.btn_tumsatislar.Size = new System.Drawing.Size(161, 59);
            this.btn_tumsatislar.TabIndex = 32;
            this.btn_tumsatislar.Text = "Tüm Kasaların Satışları";
            this.btn_tumsatislar.UseVisualStyleBackColor = true;
            this.btn_tumsatislar.Click += new System.EventHandler(this.btn_tumsatislar_Click);
            // 
            // lbl_personelno
            // 
            this.lbl_personelno.AutoSize = true;
            this.lbl_personelno.Location = new System.Drawing.Point(8, 25);
            this.lbl_personelno.Name = "lbl_personelno";
            this.lbl_personelno.Size = new System.Drawing.Size(99, 20);
            this.lbl_personelno.TabIndex = 33;
            this.lbl_personelno.Text = "Personel No:";
            // 
            // lbl_personeladsoyad
            // 
            this.lbl_personeladsoyad.AutoSize = true;
            this.lbl_personeladsoyad.Location = new System.Drawing.Point(8, 65);
            this.lbl_personeladsoyad.Name = "lbl_personeladsoyad";
            this.lbl_personeladsoyad.Size = new System.Drawing.Size(154, 20);
            this.lbl_personeladsoyad.TabIndex = 34;
            this.lbl_personeladsoyad.Text = "Personel Adı Soyadı:";
            // 
            // txt_perno
            // 
            this.txt_perno.Location = new System.Drawing.Point(168, 22);
            this.txt_perno.Name = "txt_perno";
            this.txt_perno.Size = new System.Drawing.Size(156, 26);
            this.txt_perno.TabIndex = 35;
            // 
            // txt_peradsoy
            // 
            this.txt_peradsoy.Location = new System.Drawing.Point(168, 62);
            this.txt_peradsoy.Name = "txt_peradsoy";
            this.txt_peradsoy.Size = new System.Drawing.Size(156, 26);
            this.txt_peradsoy.TabIndex = 36;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(339, 123);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(161, 59);
            this.btn_cikis.TabIndex = 37;
            this.btn_cikis.Text = "Kasiyer Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // list_tumsatisdokumu
            // 
            this.list_tumsatisdokumu.FormattingEnabled = true;
            this.list_tumsatisdokumu.ItemHeight = 20;
            this.list_tumsatisdokumu.Location = new System.Drawing.Point(12, 190);
            this.list_tumsatisdokumu.Name = "list_tumsatisdokumu";
            this.list_tumsatisdokumu.Size = new System.Drawing.Size(1246, 284);
            this.list_tumsatisdokumu.TabIndex = 38;
            // 
            // txt_terminalno
            // 
            this.txt_terminalno.Location = new System.Drawing.Point(168, 96);
            this.txt_terminalno.Name = "txt_terminalno";
            this.txt_terminalno.Size = new System.Drawing.Size(156, 26);
            this.txt_terminalno.TabIndex = 40;
            // 
            // lbl_terno
            // 
            this.lbl_terno.AutoSize = true;
            this.lbl_terno.Location = new System.Drawing.Point(8, 99);
            this.lbl_terno.Name = "lbl_terno";
            this.lbl_terno.Size = new System.Drawing.Size(97, 20);
            this.lbl_terno.TabIndex = 39;
            this.lbl_terno.Text = "Terminal No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 570);
            this.Controls.Add(this.txt_terminalno);
            this.Controls.Add(this.lbl_terno);
            this.Controls.Add(this.list_tumsatisdokumu);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txt_peradsoy);
            this.Controls.Add(this.txt_perno);
            this.Controls.Add(this.lbl_personeladsoyad);
            this.Controls.Add(this.lbl_personelno);
            this.Controls.Add(this.btn_tumsatislar);
            this.Controls.Add(this.list_satisdokumu);
            this.Controls.Add(this.btn_gorevligiris);
            this.Controls.Add(this.btn_satislisteleme);
            this.Controls.Add(this.btn_urunguncelleme);
            this.Controls.Add(this.btn_giristamamla);
            this.Controls.Add(this.txt_urungramaj);
            this.Controls.Add(this.lbl_gramaj);
            this.Controls.Add(this.txt_urunfiyat);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_miktar);
            this.Controls.Add(this.txt_urunmiktar);
            this.Controls.Add(this.lbl_tanim);
            this.Controls.Add(this.txt_uruntanim);
            this.Controls.Add(this.lbl_urunkodu);
            this.Controls.Add(this.txt_urunkodu);
            this.Controls.Add(this.btn_urungirisi);
            this.Controls.Add(this.txt_odemeturu);
            this.Controls.Add(this.lbl_odemeturu);
            this.Controls.Add(this.btn_musterionay);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.lbl_ad_soyad);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.btn_satıs);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_SiparisEdilenUrunler);
            this.Controls.Add(this.lbl_urunler);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.list_urunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_urunler;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Label lbl_urunler;
        private System.Windows.Forms.ListBox list_SiparisEdilenUrunler;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_satıs;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Button btn_musterionay;
        private System.Windows.Forms.Label lbl_odemeturu;
        private System.Windows.Forms.TextBox txt_odemeturu;
        private System.Windows.Forms.Button btn_urungirisi;
        private System.Windows.Forms.TextBox txt_urunfiyat;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_miktar;
        private System.Windows.Forms.TextBox txt_urunmiktar;
        private System.Windows.Forms.Label lbl_tanim;
        private System.Windows.Forms.TextBox txt_uruntanim;
        private System.Windows.Forms.Label lbl_urunkodu;
        private System.Windows.Forms.TextBox txt_urunkodu;
        private System.Windows.Forms.TextBox txt_urungramaj;
        private System.Windows.Forms.Label lbl_gramaj;
        private System.Windows.Forms.Button btn_giristamamla;
        private System.Windows.Forms.Button btn_urunguncelleme;
        private System.Windows.Forms.Button btn_satislisteleme;
        private System.Windows.Forms.Button btn_gorevligiris;
        private System.Windows.Forms.ListBox list_satisdokumu;
        private System.Windows.Forms.Button btn_tumsatislar;
        private System.Windows.Forms.Label lbl_personelno;
        private System.Windows.Forms.Label lbl_personeladsoyad;
        private System.Windows.Forms.TextBox txt_perno;
        private System.Windows.Forms.TextBox txt_peradsoy;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ListBox list_tumsatisdokumu;
        private System.Windows.Forms.TextBox txt_terminalno;
        private System.Windows.Forms.Label lbl_terno;
    }
}

