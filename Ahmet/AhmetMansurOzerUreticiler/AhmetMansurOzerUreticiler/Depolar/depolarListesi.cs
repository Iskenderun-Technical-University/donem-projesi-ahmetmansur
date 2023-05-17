using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMansurOzerUreticiler.Depolar
{
    public partial class depolarListesi : Form
    {
        public string kosul = "";
        int ureticiId = 0;
        depolar d = null;
        public depolarListesi(int _ureticiId)
        {
            InitializeComponent();
            ureticiId = _ureticiId;
            listeYukle("");
        }

        public void listeYukle(string _kosul)
        {
            d = new depolar();
            kosul = _kosul;
            dgvDepolar.DataSource = d.depolarCevir(this.ureticiId, this.kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvDepolar.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvDepolar.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            string ara = araTxt.Text;
            listeYukle("depolar.adi like '%" + ara + "%'");
        }

        private void depoEkleBtn_Click(object sender, EventArgs e)
        {
            audepolar audepolarfrm = new audepolar("ekle", 0, ureticiId, this);
            audepolarfrm.ShowDialog();
        }

        private void depoDegistir_Click(object sender, EventArgs e)
        {
            audepolar audepolarfrm = new audepolar("değiştir", seciliSatirIdsi(), ureticiId, this);
            audepolarfrm.ShowDialog();
        }

        private void depoSil_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("Seçili Depo Sistemden Silinecek! Onaylıyor musunuz?", sistem.pAdi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (btn == DialogResult.OK)
            {
                d = new depolar(seciliSatirIdsi());
                d.depoSil();
                listeYukle(this.kosul);
            }
        }
    }
}
