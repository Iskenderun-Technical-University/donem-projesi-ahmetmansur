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
    public partial class urunlerListesi : Form
    {
        public string kosul = "";
        urunler u = null;
        public urunlerListesi()
        {
            InitializeComponent();
            listeYukle("");
        }

        public void listeYukle(string _kosul)
        {
            kosul = _kosul;
            u = new urunler();
            dgvUrunler.DataSource = u.urunlerCevir(kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvUrunler.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvUrunler.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            listeYukle("urun like '%" + araTxt.Text + "%'");
        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            auurunler auurunlerfrm = new auurunler("ekle", 0, this);
            auurunlerfrm.ShowDialog();
        }

        private void urunDegistir_Click(object sender, EventArgs e)
        {
            auurunler auurunlerfrm = new auurunler("değiştir", seciliSatirIdsi(), this);
            auurunlerfrm.ShowDialog();
        }

        private void stokEkle_Click(object sender, EventArgs e)
        {
            Depolar.depoSec depoSecfrm = new Depolar.depoSec(seciliSatirIdsi());
            depoSecfrm.ShowDialog();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("Seçili Ürün Silinecek! Onaylıyor musunuz?", sistem.pAdi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (btn == DialogResult.OK)
            {
                u = new urunler(seciliSatirIdsi());
                u.urunSil();
                listeYukle(this.kosul);
            }
        }
    }
}
