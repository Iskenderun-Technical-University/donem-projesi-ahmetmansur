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
    public partial class aumusteri : Form
    {
        int idno = 0;
        string tip = "";
        musteriler m = new musteriler();
        bool durum = false;
        musterilerListesi musterilerListesifrm = null;
        public aumusteri(string _tip, int _idno, musterilerListesi _musterilerListesifrm)
        {
            InitializeComponent();
            tip = _tip;
            idno = _idno;
            musterilerListesifrm = _musterilerListesifrm;

            if (this.tip == "ekle")
                Text = "Yeni Müşteri Ekle";
            else if(this.tip=="değiştir")
            {
                Text = "Müşteri Bilgisi Değiştir";
                m = new musteriler(this.idno);
                m.id = this.idno;
                txtAdi.Text = m.adi;
                txtTel.Text = m.telefon;
                txtMail.Text = m.mail;
                txtAdres.Text = m.adres;
                txtKad.Text = m.kad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAdi.Text.Trim()!="")
            {
                if (txtTel.Text.Trim() != "")
                {
                    if (txtMail.Text.Trim() != "")
                    {
                        if (txtKad.Text != "")
                        {
                            if (txtAdres.Text.Trim() != "")
                            {
                                m.adi = txtAdi.Text;
                                m.telefon = txtTel.Text;
                                m.mail = txtMail.Text;
                                m.adres = txtAdres.Text;
                                m.kad = txtKad.Text;

                                if (tip == "ekle")
                                    m.musteriEkle();
                                else
                                    m.musteriDegistir();
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
                            txtKad.Focus();
                            MessageBox.Show("Kullanıcı Adı Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtTel.Focus();
                    MessageBox.Show("Telefon Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtAdi.Focus();
                MessageBox.Show("Müşteri Adı Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aumusteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (durum)
                musterilerListesifrm.listeYukle(musterilerListesifrm.kosul);
        }
    }
}
