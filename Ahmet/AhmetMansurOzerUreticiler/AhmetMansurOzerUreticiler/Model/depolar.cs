using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class depolar:sistem
    {
        public int id { get; set; }
        public int ureticiId { get; set; }
        public string adi { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public depolar()
        {
            return;
        }

        public depolar(int idno)
        {
            DataSet tablo = base.tabloCevir("select ureticiId, adi, telefon, adres from depolar where id=" + idno);
            if (tablo.Tables[0].Rows.Count > 0)
            {
                this.id = idno;
                this.ureticiId= Convert.ToInt32(tablo.Tables[0].Rows[0][0].ToString());
                this.adi = tablo.Tables[0].Rows[0][1].ToString();
                this.telefon = tablo.Tables[0].Rows[0][2].ToString();
                this.adres = tablo.Tables[0].Rows[0][3].ToString();
            }
        }

        public void depoEkle()
        {
            base.sorguCalistir("insert into depolar values(" + this.ureticiId + ",'" + this.adi + "','" + this.telefon + "','" +
                this.adres + "')");
        }

        public void depoDegistir()
        {
            base.sorguCalistir("update depolar set ureticiId=" + this.ureticiId + ", adi='" + this.adi + "',telefon='" + this.telefon + "',adres='" +
                this.adres + "' where id=" + this.id);
        }

        public void depoSil()
        {
            base.sorguCalistir("delete from depolar where id=" + this.id);
        }

        public int depoIdCevir(string adi)
        {
            return Convert.ToInt32(base.tabloCevir("select id from depolar where adi='" + adi + "'").Tables[0].Rows[0][0].ToString());
        }

        public string depoAdiCevir(int idno)
        {
            return base.tabloCevir("select adi from depolar where id=" + idno).Tables[0].Rows[0][0].ToString();
        }

        public string[] depoAdlari()
        {
            DataSet tablo = base.tabloCevir("select adi from depolar order by adi");
            string[] adlar = new string[tablo.Tables[0].Rows.Count];
            for (int i = 0; i < adlar.Length; i++)
                adlar[i] = tablo.Tables[0].Rows[i][0].ToString();
            return adlar;
        }

        public string[] depoAdlari(int ureticiId)
        {
            DataSet tablo = base.tabloCevir("select adi from depolar where ureticiId=" + ureticiId);
            string[] adlar = new string[tablo.Tables[0].Rows.Count];
            for (int i = 0; i < adlar.Length; i++)
                adlar[i] = tablo.Tables[0].Rows[i][0].ToString();
            return adlar;
        }

        public string depoAdiStokIdile(int stokid)
        {
            return base.tabloCevir("select depolar.adi from stoklar " +
                "inner join depolar on stoklar.depoid=depolar.id where stok.id=" + stokid).Tables[0].Rows[0][0].ToString();
        }

        public DataSet depolarCevir(int ureticiId, string kosul = "")
        {
            string sorgu = "select id as [ID], adi as [Depo Adı], telefon as [Telefon] from depolar " +
                "where ureticiId=" + ureticiId+" ";
            sorgu += kosul == "" ? "order by adi" : "and " + kosul + " order by adi";
            return base.tabloCevir(sorgu);
        }
    }
}
