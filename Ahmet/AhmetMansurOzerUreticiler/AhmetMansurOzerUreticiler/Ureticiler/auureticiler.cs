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
    public partial class auureticiler : Form
    {
        int idno = 0;
        string tip = "";
        ureticiler u = new ureticiler();
        bool durum = false;
        ureticilerListesi ureticilerListesifrm = null;
        public auureticiler(string _tip, int _idno, ureticilerListesi _ureticilerListesifrm)
        {
            InitializeComponent();
            tip = _tip;
            idno = _idno;
            ureticilerListesifrm = _ureticilerListesifrm;

            if (this.tip == "ekle")
                Text = "Yeni Üretici Ekle";
            else if (this.tip == "değiştir")
            {
                Text = "Üretici Bilgisi Değiştir";
                u = new ureticiler(this.idno);
                txtFabrika.Text = u.fabrika;
                txtTelefon.Text = u.telefon;
                txtMail.Text = u.mail;
                txtKad.Text = u.kad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFabrika.Text.Trim() != "")
            {
                if (txtTelefon.Text.Trim() != "")
                {
                    if (txtMail.Text.Trim() != "")
                    {
                        if(txtKad.Text!="")
                        {
                            u.fabrika = txtFabrika.Text;
                            u.telefon = txtTelefon.Text;
                            u.mail = txtMail.Text;
                            u.kad = txtKad.Text;

                            if (tip == "ekle")
                                u.ureticiEkle();
                            else
                                u.ureticiDegistir();
                            this.durum = true;
                            this.Close();
                        }
                        else
                        {
                            txtKad.Focus();
                            MessageBox.Show("Kullanıcı Adı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        txtMail.Focus();
                        MessageBox.Show("Mail Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtTelefon.Focus();
                    MessageBox.Show("Telefon Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtFabrika.Focus();
                MessageBox.Show("Fabrika Adı Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void auureticiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (durum)
                ureticilerListesifrm.listeYukle(ureticilerListesifrm.kosul);
        }
    }
}
