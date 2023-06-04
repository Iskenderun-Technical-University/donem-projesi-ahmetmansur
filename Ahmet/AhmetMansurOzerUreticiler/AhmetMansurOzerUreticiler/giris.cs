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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            tipCmbYukle();
        }

        void tipCmbYukle()
        {
            tipCmb.Items.Add("Seçiniz..");
            tipCmb.Items.Add("Müşteri Girişi");
            tipCmb.Items.Add("Üretici Girişi");
            tipCmb.SelectedIndex = 0;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            //polymorphism
            sistem s = new siparisler();

            if (tipCmb.SelectedIndex != 0)
            {
                if (s.baglantiKontrolu())
                {
                    if (txtKad.Text.Length != 0)
                    {
                        if (txtSifre.Text.Length != 0)
                        {
                            if (s.sistemGiris(tipCmb.SelectedIndex, txtKad.Text, txtSifre.Text))
                            {
                                this.Hide();
                                if (tipCmb.SelectedIndex != 1)
                                {
                                    ureticilerForm ureticilerFormfrm = new ureticilerForm();
                                    ureticilerFormfrm.Show();
                                }
                                else
                                {
                                    musterilerForm musterilerFormfrm = new musterilerForm();
                                    musterilerFormfrm.ShowDialog();
                                }
                            }
                            else
                            {
                                txtKad.Focus();
                                MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı. Lütfen Tekrar Deneyin!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            txtSifre.Focus();
                            MessageBox.Show("Şifre Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        txtKad.Focus();
                        MessageBox.Show("Kullanıcı Adı Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanı Bağlantı Hatası Oluştu. Sistem Yöneticisine Bildiriniz!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                tipCmb.Focus();
                MessageBox.Show("Giriş Tipi Seçilmelidir!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
