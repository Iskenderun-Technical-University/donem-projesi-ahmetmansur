using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMansurOzerUreticiler.Urunler
{
    public partial class auurunler : Form
    {
        int idno = 0;
        string tip = "";
        urunler u = new urunler();
        bool durum = false;
        urunlerListesi urunlerListesifrm = null;
        public auurunler(string _tip, int _idno, urunlerListesi _urunlerListesifrm)
        {
            InitializeComponent();
            this.tip = _tip;
            this.idno = _idno;
            urunlerListesifrm = _urunlerListesifrm;

            if (this.tip == "ekle")
                Text = "Yeni Ürün Ekle";
            else if (this.tip == "değiştir")
            {
                Text = "Ürün Bilgisi Değiştir";
                u = new urunler(this.idno);
                txtUrun.Text = u.urun;
                txtOzellikler.Text = u.ozellikler;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUrun.Text.Trim() != "")
            {
                if (txtOzellikler.Text.Trim() != "")
                {
                    u.urun = txtUrun.Text;
                    u.ozellikler = txtOzellikler.Text;

                    if (tip == "ekle")
                        u.urunEkle();
                    else
                        u.urunDegistir();
                    this.durum = true;
                    this.Close();
                }
                else
                {
                    txtOzellikler.Focus();
                    MessageBox.Show("Ürün Özellikleri Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtUrun.Focus();
                MessageBox.Show("Ürün Adı Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void auurun_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (durum)
                urunlerListesifrm.listeYukle(urunlerListesifrm.kosul);
        }
    }
}
