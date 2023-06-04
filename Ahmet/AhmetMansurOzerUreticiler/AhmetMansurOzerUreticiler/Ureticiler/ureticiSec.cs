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
    public partial class ureticiSec : Form
    {
        ureticiler u = null;
        int idno = 0;
        public ureticiSec()
        {
            InitializeComponent();
            listeYukle("");
        }

        void listeYukle(string kosul)
        {
            ureticilerLst.Items.Clear();
            u = new ureticiler();
            string[] uAdlari = null;
            if (kosul == "")
                uAdlari = u.ureticiAdlari();
            else
                uAdlari = u.ureticiAdlari(kosul);
            foreach (string adi in uAdlari)
                ureticilerLst.Items.Add(adi);
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            if (araTxt.Text != "")
                listeYukle(araTxt.Text);
            else
                listeYukle("");
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            if (ureticilerLst.SelectedItem != null)
            {
                u = new ureticiler();
                idno = u.ureticiIdCevir(ureticilerLst.SelectedItem.ToString());
                this.Close();
            }
        }

        private void ureticiSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.idno != 0)
            {
                Depolar.depolarListesi depolarListesifrm = new Depolar.depolarListesi(idno);
                depolarListesifrm.ShowDialog();
            }
        }
    }
}
