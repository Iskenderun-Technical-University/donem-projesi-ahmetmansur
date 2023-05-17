using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class siparisler:sistem
    {
        public int id { get; set; }
        public int musteriId { get; set; }
        public int stokId { get; set; }
        public int miktar { get; set; }
        public int uretilecekMiktar { get; set; }
        public DateTime ktarih { get; set; }

        public siparisler()
        {
            return;
        }

        public siparisler(int idno)
        {
            DataSet tablo = base.tabloCevir("select musteriId,stokId,miktar,uretilecekMiktar,ktarih from siparisler where id=" + idno);
            if (tablo.Tables[0].Rows.Count > 0)
            {
                this.id = idno;
                this.musteriId = Convert.ToInt32(tablo.Tables[0].Rows[0][0].ToString());
                this.stokId = Convert.ToInt32(tablo.Tables[0].Rows[0][1].ToString());
                this.miktar = Convert.ToInt32(tablo.Tables[0].Rows[0][2].ToString());
                this.uretilecekMiktar= Convert.ToInt32(tablo.Tables[0].Rows[0][3].ToString());
                this.ktarih = Convert.ToDateTime(tablo.Tables[0].Rows[0][4].ToString());
            }
        }

        public void uretilecekMiktarHesapla()
        {
            int stokMiktar = Convert.ToInt32(base.tabloCevir("select miktar from stoklar where id=" + this.stokId).Tables[0].Rows[0][0]);
            if (this.miktar > stokMiktar)
                this.uretilecekMiktar = this.miktar - stokMiktar;
        }

        public void yenidenMiktarHesapla(int istenenMiktar)
        {
            int sonuc = Convert.ToInt32(base.tabloCevir("select miktar from stoklar where id=" + this.stokId).Tables[0].Rows[0][0]);
            int yeniMiktar = 0;
            if (sonuc > istenenMiktar)
                yeniMiktar = sonuc - istenenMiktar;
            else
                yeniMiktar = 0;

            base.sorguCalistir("update stoklar set miktar=" + yeniMiktar + " where id=" + this.stokId);
        }

        public void siparisEkle()
        {
            base.sorguCalistir("insert into siparisler values(" + this.musteriId + "," +
                this.stokId + "," + this.miktar + ","+this.uretilecekMiktar+",'"+base.veritabaniTarihFormati(this.ktarih)+"','Yeni')");
        }

        public void siparisDegistir()
        {
            base.sorguCalistir("update siparisler set musteriId=" + this.musteriId + ", stockId=" +
                this.stokId + ", miktar=" + this.miktar + ", uretilecekMiktar=" + this.uretilecekMiktar + ", ktarih='" + base.veritabaniTarihFormati(this.ktarih) + "' where id=" + this.id);
        }

        public void siparisDurumuDegistir(string durum)
        {
            base.sorguCalistir("update siparisler set durum='" + durum + "' where id=" + this.id);
        }

        public void siparisSil()
        {
            base.sorguCalistir("delete from siparisler where id=" + this.id);
        }

        public DataSet ureticilerSiparislerCevir(string kosul = "")
        {
            string sorgu = "select siparisler.id as [ID], musteriler.adi as [Müşteri Adı], depolar.adi as [Depo Adı]," +
                "urunler.urun as [Ürün], siparisler.miktar as [Sipariş Miktar], siparisler.ktarih as [Sipariş Tarihi], stoklar.miktar as [Stok Miktarı], siparisler.uretilecekMiktar as [Üretilecek Miktar]," +
                "siparisler.durum as [Sipariş Durumu] from siparisler "+
                "inner join musteriler on siparisler.musteriId=musteriler.id " +
                "inner join stoklar on siparisler.stokId=stoklar.id "+
                "inner join depolar on stoklar.depoId=depolar.id " +
                "inner join urunler on stoklar.urunId=urunler.id ";
            sorgu += kosul == "" ? "order by siparisler.id" : "where " + kosul + " order by siparisler.id";
            return base.tabloCevir(sorgu);
        }

        public DataSet musterilerSiparislerCevir(int musteriId, string kosul = "")
        {
            string sorgu = "select siparisler.id as [ID], musteriler.adi as [Müşteri Adı], depolar.adi as [Depo Adı]," +
                "urunler.urun as [Ürün], siparisler.miktar as [Sipariş Miktar], siparisler.ktarih as [Sipariş Tarihi], stoklar.miktar as [Stok Miktarı], siparisler.uretilecekMiktar as [Üretilecek Miktar]," +
                "siparisler.durum as [Sipariş Durumu] from siparisler " +
                "inner join musteriler on siparisler.musteriId=musteriler.id " +
                "inner join stoklar on siparisler.stokId=stoklar.id " +
                "inner join depolar on stoklar.depoId=depolar.id " +
                "inner join urunler on stoklar.urunId=urunler.id where siparisler.musteriId=" + musteriId;
            sorgu += kosul == "" ? "order by siparisler.id" : " and " + kosul + " order by siparisler.id";
            return base.tabloCevir(sorgu);
        }
    }
}
