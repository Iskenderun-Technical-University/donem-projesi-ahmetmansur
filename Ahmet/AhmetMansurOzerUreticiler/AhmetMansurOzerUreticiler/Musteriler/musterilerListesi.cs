using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMansurOzerUreticiler.Musteriler
{
    public partial class musterilerListesi : Form
    {
        public string kosul = "";
        musteriler m = null;
        public musterilerListesi()
        {
            InitializeComponent();
            listeYukle("");
        }

        public void listeYukle(string _kosul)
        {
            kosul = _kosul;
            m = new musteriler();
            dgvMusteriler.DataSource = m.musterilerCevir(kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvMusteriler.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvMusteriler.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            listeYukle("adi like '%" + araTxt.Text + "%'");
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            aumusteri aumusterifrm = new aumusteri("ekle", 0, this);
            aumusterifrm.ShowDialog();
        }

        private void musteriDegistir_Click(object sender, EventArgs e)
        {
            aumusteri aumusterifrm = new aumusteri("değiştir", seciliSatirIdsi(), this);
            aumusterifrm.ShowDialog();
        }

        private void musteriSil_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("Seçili Müşteri Silinecek! Onaylıyor musunuz?", sistem.pAdi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (btn == DialogResult.OK)
            {
                m = new musteriler(seciliSatirIdsi());
                m.musteriSil();
                listeYukle(this.kosul);
            }
        }

        private void sifreDegistir_Click(object sender, EventArgs e)
        {
            usifre usifrefrm = new usifre("müşteri", seciliSatirIdsi());
            usifrefrm.ShowDialog();
        }
    }
}
