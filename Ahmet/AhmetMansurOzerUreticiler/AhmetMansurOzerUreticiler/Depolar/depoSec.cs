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
    public partial class depoSec : Form
    {
        depolar d = null;
        int urunId = 0, depoId=0;
        public depoSec(int _urunId)
        {
            InitializeComponent();
            urunId = _urunId;
            listeYukle();
        }

        void listeYukle()
        {
            depolarLst.Items.Clear();
            d = new depolar();
            string[] wnames = d.depoAdlari(sistem.fabrikamId);

            foreach (string name in wnames)
                depolarLst.Items.Add(name);
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            if (depolarLst.SelectedItem != null)
            {
                d = new depolar();
                depoId = Convert.ToInt32(d.depoIdCevir(depolarLst.SelectedItem.ToString()));
                this.Close();
            }
        }

        private void depoSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.depoId != 0)
            {
                Stoklar.austok austokfrm = new Stoklar.austok("ekle", 0, this.urunId, this.depoId);
                austokfrm.ShowDialog();
            }
        }
    }
}
