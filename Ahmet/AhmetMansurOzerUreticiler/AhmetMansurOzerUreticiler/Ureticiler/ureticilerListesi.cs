using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMansurOzerUreticiler.Ureticiler
{
    public partial class ureticilerListesi : Form
    {
        public string kosul = "";
        ureticiler u = null;
        public ureticilerListesi()
        {
            InitializeComponent();
            listeYukle("");
        }

        public void listeYukle(string _kosul)
        {
            kosul = _kosul;
            u = new ureticiler();
            dgvUreticiler.DataSource = u.ureticilerCevir(kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvUreticiler.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvUreticiler.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            listeYukle("fabrika like '%" + araTxt.Text + "%'");
        }

        private void ureticiEkleBtn_Click(object sender, EventArgs e)
        {
            auureticiler auureticilerfrm = new auureticiler("ekle", 0, this);
            auureticilerfrm.ShowDialog();
        }

        private void ureticiDegistir_Click(object sender, EventArgs e)
        {
            auureticiler auureticilerfrm = new auureticiler("değiştir", seciliSatirIdsi(), this);
            auureticilerfrm.ShowDialog();
        }

        private void depolarMenu_Click(object sender, EventArgs e)
        {
            Depolar.depolarListesi depolarListesifrm = new Depolar.depolarListesi(seciliSatirIdsi());
            depolarListesifrm.ShowDialog();
        }

        private void ureticiSil_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("Seçili Üretici Sistemden Silinecek! Onaylıyor musunuz?", sistem.pAdi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (btn == DialogResult.OK)
            {
                u = new ureticiler(seciliSatirIdsi());
                u.ureticiSil();
                listeYukle(this.kosul);
            }
        }

        private void sifreDegistir_Click(object sender, EventArgs e)
        {
            usifre usifrefrm = new usifre("üretici", seciliSatirIdsi());
            usifrefrm.ShowDialog();
        }
    }
}
