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
    public partial class usifre : Form
    {
        int idno = 0;
        string tip = "";
        public usifre(string _tip, int _idno)
        {
            InitializeComponent();
            idno = _idno;
            tip = _tip;
        }

        private void degistirBtn_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim())
            {
                if (txtSifre.Text.Trim() != "")
                {
                    if (txtSifreTekrar.Text.Trim() != "")
                    {
                        if (tip == "üretici")
                        {
                            ureticiler u = new ureticiler(idno);
                            u.sifreGuncelle(txtSifre.Text);
                        }
                        else
                        {
                            musteriler m = new musteriler(idno);
                            m.sifreDegistir(txtSifre.Text);
                        }
                        MessageBox.Show("Şifre Değiştirildi.", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        txtSifre.Focus();
                        MessageBox.Show("Yeni Şifre Tekrar Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtSifre.Focus();
                    MessageBox.Show("Şifre Alanı Boş Geçilemez!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtSifre.Focus();
                MessageBox.Show("Girilen Şifreler Aynı Olmalıdır!", sistem.pAdi, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
