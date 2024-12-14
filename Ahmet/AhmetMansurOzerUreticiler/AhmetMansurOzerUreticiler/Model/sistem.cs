using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AhmetMansurOzerUreticiler
{
    class sistem
    {
        public static string pAdi = "Ahmet Mansur Üreticiler";
        public static int musterimId = 0, fabrikamId=0;
        private SqlConnection baglanti()
        {
            SqlConnectionStringBuilder p = new SqlConnectionStringBuilder();
            p.DataSource = ".\\SQLEXPRESS";
            //provider.DataSource = ".";
            p.InitialCatalog = "ureticilerdb";
            p.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection(p.ConnectionString);
            return conn;
        }

        public bool baglantiKontrolu()
        {
            bool connState = false;
            try
            {
                SqlConnection conn = this.baglanti();
                conn.Open();
                connState = true;
            }
            catch
            {
                connState = false;
            }
            return connState;
        }

        public bool sistemGiris(int tip, string kad, string sifre)
        {
            DataSet sonuc = null;
            if (tip == 1)
            {
                sonuc = this.tabloCevir("select id from musteriler where kad='" + kad + "' and sifre='" + sifre + "'");
                if (sonuc.Tables[0].Rows.Count > 0)
                {
                    sistem.musterimId = Convert.ToInt32(sonuc.Tables[0].Rows[0][0]);
                    if (sistem.musterimId!= 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
                
            }
            else
            {
                sonuc = this.tabloCevir("select id from ureticiler where kad='" + kad + "' and sifre='" + sifre + "'");
                if (sonuc.Tables[0].Rows.Count > 0)
                {
                    sistem.fabrikamId = Convert.ToInt32(sonuc.Tables[0].Rows[0][0]);
                    if (sistem.fabrikamId != 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }

        public DataSet tabloCevir(string sorgu)
        {
            SqlConnection conn = this.baglanti();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            conn.Dispose();
            adapter.Dispose();

            return ds;
        }

        public void sorguCalistir(string sorgu)
        {
            SqlConnection conn = this.baglanti();
            SqlCommand cmd = new SqlCommand(sorgu, conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        public string veritabaniTarihFormati(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day;
        }
    }
}
