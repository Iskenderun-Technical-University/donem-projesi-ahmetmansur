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
    public partial class audepolar : Form
    {
        int idno = 0, ureticiId=0;
        string tip = "";
        depolar d = new depolar();
        bool durum = false;
        depolarListesi depolarListesifrm = null;
        public audepolar(string _tip, int _idno, int _ureticiId, depolarListesi _depolarListesifrm)
        {
            InitializeComponent();
            tip = _tip;
            idno = _idno;
            ureticiId = _ureticiId;
            depolarListesifrm = _depolarListesifrm;
            
            if (this.tip == "ekle")
                Text = "Yeni Depo Ekle";
            else if (this.tip == "değiştir")
            {
                Text = "Update Warehouse";
                d = new depolar(this.idno);
                txtAdi.Text = d.adi;
                txtTel.Text = d.telefon;
                txtAdres.Text = d.adres;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "")
            {
                if (txtTel.Text.Trim() != "")
                {
                    if (txtAdres.Text.Trim() != "")
                    {
                        d.ureticiId = ureticiId;
                        d.adi = txtAdi.Text;
                        d.telefon = txtTel.Text;
                        d.adres = txtAdres.Text;
                        if (tip == "add")
                            d.depoEkle();
                        else
                            d.depoDegistir();
                        this.durum = true;
                        this.Close();

                    }
                    else
                    {
                        txtAdres.Focus();
                        MessageBox.Show("Adres Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtTel.Focus();
                    MessageBox.Show("Telefon Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtAdi.Focus();
                MessageBox.Show("Depo Adı Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void auwarehouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(durum)
                depolarListesifrm.listeYukle(depolarListesifrm.kosul);
        }
    }
}
