using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class stoklar:sistem
    {
        public int id { get; set; }
        public int urunId { get; set; }
        public int depoId { get; set; }
        public int miktar { get; set; }

        public stoklar()
        {
            return;
        }

        public stoklar(int idno)
        {
            DataSet tablo = base.tabloCevir("select urunId, depoId, miktar from stoklar where id=" + idno);
            if (tablo.Tables[0].Rows.Count > 0)
            {
                this.id = idno;
                this.urunId = Convert.ToInt32(tablo.Tables[0].Rows[0][0].ToString());
                this.depoId = Convert.ToInt32(tablo.Tables[0].Rows[0][1].ToString());
                this.miktar = Convert.ToInt32(tablo.Tables[0].Rows[0][2].ToString());
            }
        }

        public void stokEkle()
        {
            base.sorguCalistir("insert into stoklar values(" + this.urunId + "," + this.depoId +
                "," + this.miktar + ")");
        }

        public void stokDegistir()
        {
            base.sorguCalistir("update stoklar set urunId=" + this.urunId + ", depoId=" + this.depoId +
                ", miktar=" + this.miktar + " where id=" + this.id);
        }

        public void stokSil()
        {
            base.sorguCalistir("delete from stoklar where id = " + this.id);
        }

        public DataSet stoklarCevir(int ureticiId, string kosul = "")
        {
            string sorgu = "select stoklar.id as [ID], depolar.adi as [Depo Adı], urunler.urun as [Ürünler], stoklar.miktar as [Stok Miktarı] from stoklar "+
                "inner join depolar on stoklar.depoId=depolar.id "+
                "inner join urunler on stoklar.urunId=urunler.id where depolar.ureticiId="+ureticiId;
            sorgu += kosul == "" ? " order by urunler.urun" : " and " + kosul + " order by products.product";
            return base.tabloCevir(sorgu);
        }

        public DataSet stoklarCevir(string kosul = "")
        {
            string sorgu = "select stoklar.id as [ID], depolar.adi as [Depo Adı], urunler.urun as [Ürünler], stoklar.miktar as [Stok Miktarı] from stoklar " +
                "inner join depolar on stoklar.depoId=depolar.id " +
                "inner join urunler on stoklar.urunId=urunler.id";
            sorgu += kosul == "" ? " order by urunler.urun" : " where " + kosul + " order by products.product";
            return base.tabloCevir(sorgu);
        }
    }
}
