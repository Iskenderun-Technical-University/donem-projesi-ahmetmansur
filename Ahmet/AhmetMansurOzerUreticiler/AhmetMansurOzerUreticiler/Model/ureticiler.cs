using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class ureticiler:sistem
    {
        public int id { get; set; }
        public string fabrika { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string kad { get; set; }

        public ureticiler()
        {
            return;
        }

        public ureticiler(int idno)
        {
            DataSet table = base.tabloCevir("select fabrika,telefon,mail,kad from ureticiler where id=" + idno);
            if (table.Tables[0].Rows.Count > 0)
            {
                this.id = idno;
                this.fabrika = table.Tables[0].Rows[0][0].ToString();
                this.telefon = table.Tables[0].Rows[0][1].ToString();
                this.mail = table.Tables[0].Rows[0][2].ToString();
                this.kad= table.Tables[0].Rows[0][3].ToString();
            }
        }

        public void ureticiEkle()
        {
            base.sorguCalistir("insert into ureticiler values('" + this.fabrika + "','" + this.telefon + "','" +
                this.mail + "','" + this.kad + "', '1')");
        }

        public void ureticiDegistir()
        {
            base.sorguCalistir("update ureticiler set fabrika='" + this.fabrika + "',telefon='" + this.telefon + "',mail='" +
                this.mail + "', kad='" + this.kad + "' where id=" + this.id);
        }

        public void sifreGuncelle(string yeniSifre)
        {
            base.sorguCalistir("update ureticiler set sifre='" + yeniSifre + "' where id=" + this.id);
        }

        public void ureticiSil()
        {
            base.sorguCalistir("delete from ureticiler where id=" + this.id);
        }

        public string ureticiAdiCevir(int idno)
        {
            return base.tabloCevir("select fabrika from ureticiler where id=" + idno).Tables[0].Rows[0][0].ToString();
        }

        public int ureticiIdCevir(string fabrika)
        {
            DataSet result = base.tabloCevir("select id from ureticiler where fabrika='" + fabrika + "'");
            if (result.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(result.Tables[0].Rows[0][0].ToString());
            else
                return 0;
        }

        public string ureticiAdiDepoIdile(int depoid)
        {
            return base.tabloCevir("select ureticiler.fabrika from depolar "+
                "inner join ureticiler on depolar.ureticiId=ureticiler.id where depolar.id=" + depoid).Tables[0].Rows[0][0].ToString();
        }

        public DataSet ureticilerCevir(string kosul="")
        {
            string sorgu = "select id as [ID], fabrika as [Üretici], telefon as [Telefon], mail as [E-Mail] from ureticiler ";
            sorgu += kosul == "" ? "order by fabrika" : "kosul " + kosul + " order by fabrika";
            return base.tabloCevir(sorgu);
        }

        public string[] ureticiAdlari()
        {
            DataSet tablo = base.tabloCevir("select fabrika from ureticiler order by fabrika");
            string[] ureticiler = new string[tablo.Tables[0].Rows.Count];
            for (int i = 0; i < ureticiler.Length; i++)
                ureticiler[i] = tablo.Tables[0].Rows[i][0].ToString();
            return ureticiler;
        }

        public string[] ureticiAdlari(string fabrika)
        {
            DataSet tablo = base.tabloCevir("select fabrika from ureticiler where fabrika like '%"+fabrika+"%' order by fabrika");
            string[] ureticiler = new string[tablo.Tables[0].Rows.Count];
            for (int i = 0; i < ureticiler.Length; i++)
                ureticiler[i] = tablo.Tables[0].Rows[i][0].ToString();
            return ureticiler;
        }
    }
}
