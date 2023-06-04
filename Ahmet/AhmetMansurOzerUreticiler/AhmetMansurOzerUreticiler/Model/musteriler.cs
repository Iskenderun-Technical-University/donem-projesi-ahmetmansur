using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class musteriler:sistem
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        public string kad { get; set; }

        public musteriler()
        {
            return;
        }

        public musteriler(int idno)
        {
            DataSet tablo = base.tabloCevir("select adi,telefon,mail,adres,kad from musteriler where id=" + idno);
            if(tablo.Tables[0].Rows.Count>0)
            {
                this.id = idno;
                this.adi = tablo.Tables[0].Rows[0][0].ToString();
                this.telefon = tablo.Tables[0].Rows[0][1].ToString();
                this.mail = tablo.Tables[0].Rows[0][2].ToString();
                this.adres = tablo.Tables[0].Rows[0][3].ToString();
                this.kad = tablo.Tables[0].Rows[0][4].ToString();
            }
        }

        public void musteriEkle()
        {
            base.sorguCalistir("insert into musteriler values('" + this.adi + "','" + this.telefon + "','" +
                this.mail + "','" + this.adres + "','" + this.kad + "', '1')");
        }

        public void musteriDegistir()
        {
            base.sorguCalistir("update musteriler set adi='" + this.adi + "',telefon='" + this.telefon + "',mail='" +
                this.mail + "',adres='" + this.adres + "', kad='" + this.kad + "' where id=" + this.id);
        }

        public void sifreDegistir(string yeniSifre)
        {
            base.sorguCalistir("update musteriler set password='" + yeniSifre + "' where id=" + this.id);
        }

        public void musteriSil()
        {
            base.sorguCalistir("delete from musteriler where id=" + this.id);
        }

        public string musteriAdiCevir(int idno)
        {
            return base.tabloCevir("select adi from musteriler where id=" + idno).Tables[0].Rows[0][0].ToString();
        }

        public DataSet musterilerCevir(string kosul = "")
        {
            string sorgu = "select id as [ID], adi as [Müşteri Adı], telefon as [Telefon], mail as [E-Mail] from musteriler ";
            sorgu += kosul == "" ? "order by adi" : "where " + kosul + " order by adi";
            return base.tabloCevir(kosul);
        }
    }
}
