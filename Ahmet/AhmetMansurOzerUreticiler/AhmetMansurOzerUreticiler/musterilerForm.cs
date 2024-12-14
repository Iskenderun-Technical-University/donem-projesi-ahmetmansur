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
    public partial class musterilerForm : Form
    {
        public string kosul = "";
        siparisler s = null;
        public musterilerForm()
        {
            InitializeComponent();
            listeYukle();
        }

        public void listeYukle(string _kosul="")
        {
            kosul = _kosul;
            s = new siparisler();
            dgvSiparisler.DataSource = s.musterilerSiparislerCevir(sistem.musterimId, kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvSiparisler.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvSiparisler.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        private void siparislerBtn_Click(object sender, EventArgs e)
        {
            listeYukle();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            listeYukle("urunler.urun like '%" + araTxt.Text + "%'");
        }

        private void siparisDegistir_Click(object sender, EventArgs e)
        {
            Stoklar.ausiparis ausiparisfrm = new Stoklar.ausiparis("değiştir", seciliSatirIdsi(), 0, this);
            ausiparisfrm.ShowDialog();
        }

        private void siparisSil_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("Seçili Sipariş Silinecek! Onaylıyor musunuz?", sistem.pAdi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (btn == DialogResult.OK)
            {
                s = new siparisler(seciliSatirIdsi());
                s.siparisSil();
                listeYukle(this.kosul);
            }
        }

        private void stoklarBtn_Click(object sender, EventArgs e)
        {
            Stoklar.stoklarListesi stoklarListesifrm = new Stoklar.stoklarListesi(this);
            stoklarListesifrm.ShowDialog();
        }

        private void musterilerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
