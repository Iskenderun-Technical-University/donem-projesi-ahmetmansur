using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMansurOzerUreticiler.Stoklar
{
    public partial class ausiparis : Form
    {
        int idno = 0, stokId=0;
        string tip = "";
        siparisler s = new siparisler();
        depolar d = null;
        bool durum = false;
        musterilerForm musterilerFormfrm = null;
        public ausiparis(string _type, int _idno, int _stokid, musterilerForm _musterilerFormfrm)
        {
            InitializeComponent();
            this.tip = _type;
            this.idno = _idno;
            this.stokId = _stokid;
            musterilerFormfrm = _musterilerFormfrm;

            if (this.tip == "ekle")
            {
                Text = "Yeni Sipariş Ekle";
                d = new depolar();
                txtDepo.Text = d.depoAdiStokIdile(this.stokId);
            }
            else if (this.tip == "değiştir")
            {
                Text = "Sipariş Güncelle";
                s = new siparisler(idno);
                d = new depolar();
                this.stokId = s.stokId;
                txtDepo.Text = d.depoAdiStokIdile(s.stokId);
                txtMiktar.Text = s.miktar.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMiktar.Text.Trim() != "")
            {
                s.musteriId = sistem.musterimId;
                s.stokId = this.stokId;
                s.miktar = Convert.ToInt32(txtMiktar.Text);
                s.ktarih = DateTime.Today;
                s.uretilecekMiktarHesapla();
                if (tip == "ekle")
                    s.siparisEkle();
                else
                    s.siparisDegistir();
                this.durum = true;
                this.Close();
            }
            else
            {
                txtMiktar.Focus();
                MessageBox.Show("Miktar Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ausiparis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (durum && musterilerFormfrm != null)
                musterilerFormfrm.listeYukle(musterilerFormfrm.kosul);
        }
    }
}
