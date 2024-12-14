using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMansurOzerUreticiler
{
    public partial class ureticilerForm : Form
    {
        public string kosul = "";
        siparisler s = null;
        public ureticilerForm()
        {
            InitializeComponent();
            listeYukle();
        }

        public void listeYukle(string _kosul="")
        {
            this.kosul = _kosul;
            s = new siparisler();
            dgvSiparisler.DataSource = s.ureticilerSiparislerCevir(this.kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvSiparisler.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvSiparisler.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        private void musterilerBtn_Click(object sender, EventArgs e)
        {
            Musteriler.musterilerListesi musterilerListesifrm = new Musteriler.musterilerListesi();
            musterilerListesifrm.ShowDialog();
        }

        private void ureticilerBtn_Click(object sender, EventArgs e)
        {
            Ureticiler.ureticilerListesi ureticilerListesifrm = new Ureticiler.ureticilerListesi();
            ureticilerListesifrm.ShowDialog();
        }

        private void depolarBtn_Click(object sender, EventArgs e)
        {
            Ureticiler.ureticiSec ureticiSecfrm = new Ureticiler.ureticiSec();
            ureticiSecfrm.ShowDialog();
        }

        private void urunlerBtn_Click(object sender, EventArgs e)
        {
            Urunler.urunlerListesi urunlerListesifrm = new Urunler.urunlerListesi();
            urunlerListesifrm.ShowDialog();
        }

        private void stoklarimBtn_Click(object sender, EventArgs e)
        {
            Stoklar.stoklarListesi stoklarListesifrm = new Stoklar.stoklarListesi();
            stoklarListesifrm.ShowDialog();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            if (araTxt.Text != "")
                listeYukle("musteriler.adi like '%" + araTxt.Text + "'");
            else
                listeYukle("");
        }

        private void siparisTamam_Click(object sender, EventArgs e)
        {
            siparisler s = new siparisler(seciliSatirIdsi());
            int seciliSatirIndisi = dgvSiparisler.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvSiparisler.Rows[seciliSatirIndisi];
            int miktar = Convert.ToInt32(seciliSatir.Cells[6].Value);
            int uretilecekMiktar = Convert.ToInt32(seciliSatir.Cells[7].Value);
            s.yenidenMiktarHesapla((miktar + uretilecekMiktar));
            s.siparisDurumuDegistir("Tamamlandı");
            listeYukle(kosul);
        }

        private void ureticilerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
