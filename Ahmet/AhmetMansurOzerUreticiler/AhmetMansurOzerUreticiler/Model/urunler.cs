using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class urunler:sistem
    {
        public int id { get; set; }
        public string urun { get; set; }
        public string ozellikler { get; set; }

        public urunler()
        {
            return;
        }

        public urunler(int idno)
        {
            DataSet tablo = base.tabloCevir("select urun, ozellikler from urunler where id=" + idno);
            if (tablo.Tables[0].Rows.Count > 0)
            {
                this.id = idno;
                this.urun = tablo.Tables[0].Rows[0][0].ToString();
                this.ozellikler = tablo.Tables[0].Rows[0][1].ToString();
            }
        }

        public void urunEkle()
        {
            base.sorguCalistir("insert into urunler values('" + this.urun + "','" + this.ozellikler + "')");
        }

        public void urunDegistir()
        {
            base.sorguCalistir("update urunler set urun='" + this.urun + "', ozellikler='" + this.ozellikler +
                "' where id=" + this.id);
        }

        public void urunSil()
        {
            base.sorguCalistir("delete from urunler where id = " + this.id);
        }

        public string urunCevir(int idno)
        {
            return base.tabloCevir("select urun from urunler where id=" + idno).Tables[0].Rows[0][0].ToString();
        }

        public int urunIdCevir(string urun)
        {
            return Convert.ToInt32(base.tabloCevir("select id from urunler where name='" + urun + "'").Tables[0].Rows[0][0].ToString());
        }

        public DataSet urunlerCevir(string kosul = "")
        {
            string sorgu = "select id as [ID], urun as [Ürün], ozellikler as [Özellikleri] from urunler ";
            sorgu += kosul == "" ? "order by urun" : "where " + kosul + " order by urun";
            return base.tabloCevir(sorgu);
        }
    }
}
