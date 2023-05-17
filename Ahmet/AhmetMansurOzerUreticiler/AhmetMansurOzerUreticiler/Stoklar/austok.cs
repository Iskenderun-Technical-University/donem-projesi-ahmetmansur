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
    public partial class austok : Form
    {
        int idno = 0, urunId = 0, depoId = 0;
        string tip = "";
        stoklar s = new stoklar();
        ureticiler u = null;
        depolar d = null;
        urunler p = null;
        bool durum = false;
        stoklarListesi stoklarListesifrm = null;

        public austok(string _tip, int _idno, int _urunId, int _depoId, stoklarListesi _stoklarListesifrm = null)
        {
            InitializeComponent();
            this.tip = _tip;
            this.idno = _idno;
            this.urunId = _urunId;
            this.depoId = _depoId;
            stoklarListesifrm = _stoklarListesifrm;

            if (this.tip == "ekle")
            {
                Text = "Yeni Stok Ekle";
                u = new ureticiler();
                d = new depolar();
                p = new urunler();
                txtUretici.Text = u.ureticiAdiDepoIdile(this.depoId);
                txtDepo.Text = d.depoAdiCevir(this.depoId);
                txtUrun.Text = p.urunCevir(this.urunId);
                txtMiktar.Focus();
            }
            else if (this.tip == "değiştir")
            {
                Text = "Stok Değiştir";
                s = new stoklar(this.idno);
                u = new ureticiler();
                d = new depolar();
                p = new urunler();
                txtUrun.Text = u.ureticiAdiCevir(s.urunId);
                urunId = s.urunId;
                txtDepo.Text = d.depoAdiCevir(s.depoId);
                depoId = s.depoId;
                txtUretici.Text = u.ureticiAdiDepoIdile(s.depoId);
                txtMiktar.Text = s.miktar.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUrun.Text.Trim() != "")
            {
                s.urunId = this.urunId;
                s.depoId = this.depoId;
                s.miktar = Convert.ToInt32(txtMiktar.Text);

                if (tip == "ekle")
                    s.stokEkle();
                else
                    s.stokDegistir();
                this.durum = true;
                this.Close();
            }
            else
            {
                txtMiktar.Focus();
                MessageBox.Show("Miktar Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void austok_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.durum && this.stoklarListesifrm != null)
                stoklarListesifrm.listeYukle(stoklarListesifrm.kosul);
        }
    }
}
