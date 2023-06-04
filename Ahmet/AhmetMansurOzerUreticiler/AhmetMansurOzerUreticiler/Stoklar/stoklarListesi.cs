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
    public partial class stoklarListesi : Form
    {
        public string kosul = "";
        stoklar s = null;
        depolar d = null;
        musterilerForm musterilerFormfrm = null;
        public stoklarListesi(musterilerForm _musterilerFormfrm = null)
        {
            InitializeComponent();
            musterilerFormfrm = _musterilerFormfrm;
            depoCmbLoad();
            listeYukle("");

            if (musterilerFormfrm!=null)
            {
                sagTusMenu.Items.Clear();
                ToolStripMenuItem m1 = new ToolStripMenuItem("Sipariş Ekle");
                m1.Image = Image.FromFile("images/add16.png");
                m1.Click+= new EventHandler(siparisEkle_Click);
                sagTusMenu.Items.Add(m1);
            }
        }

        public void listeYukle(string _kosul)
        {
            s = new stoklar();
            kosul = _kosul;
            if(musterilerFormfrm==null)
                dgvStoklar.DataSource = s.stoklarCevir(sistem.fabrikamId, this.kosul).Tables[0];
            else
                dgvStoklar.DataSource = s.stoklarCevir(this.kosul).Tables[0];
        }

        int seciliSatirIdsi()
        {
            int seciliIndex = dgvStoklar.SelectedCells[0].RowIndex;
            DataGridViewRow seciliSatir = dgvStoklar.Rows[seciliIndex];
            int idno = Convert.ToInt32(seciliSatir.Cells[0].Value);
            return idno;
        }

        void depoCmbLoad()
        {
            d = new depolar();
            string[] depoAdlari = null;
            if (musterilerFormfrm == null)
                depoAdlari = d.depoAdlari(sistem.fabrikamId);
            else
                depoAdlari = d.depoAdlari();
            depoCmb.Items.Add("Seçiniz..");
            foreach (string adi in depoAdlari)
                depoCmb.Items.Add(adi);
            depoCmb.SelectedIndex = 0;
        }

        private void siparisEkle_Click(object sender, EventArgs e)
        {
            ausiparis ausiparisfrm = new ausiparis("ekle", 0, seciliSatirIdsi(), musterilerFormfrm);
            ausiparisfrm.ShowDialog();
        }

        private void stokGuncelle_Click(object sender, EventArgs e)
        {
            austok austocksfrm = new austok("değiştir", seciliSatirIdsi(), 0, 0, this);
            austocksfrm.ShowDialog();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            string aranacak = araTxt.Text;
            depoCmb.SelectedIndex = 0;
            listeYukle("urunler.urun like '%" + aranacak + "%'");
        }

        private void depoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (depoCmb.SelectedIndex != 0)
                listeYukle("depolar.adi='" + depoCmb.Text + "'");
            else
                listeYukle("");
            araTxt.Text = "";
        }

        private void stokSil_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("Seçili Stok Silinecek! Onaylıyor musunuz?", sistem.pAdi, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (btn == DialogResult.OK)
            {
                s = new stoklar(seciliSatirIdsi());
                s.stokSil();
                listeYukle(this.kosul);
            }
        }
    }
}
