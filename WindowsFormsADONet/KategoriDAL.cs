using System;
using System.Data.SqlClient;

namespace WindowsFormsADONet
{
    internal class KategoriDAL : OrtakDAL // OrtakDAL dan miras alarak onun içindekileri burada kullanabilir hale geldik
    {
        public int Add(Kategori kategori)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("insert into kategoriler (KategoriAdi) values (@KategoriAdi)", connection);

            sqlCommand.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);

            islemSonucu = sqlCommand.ExecuteNonQuery(); // sorgu çalıştığında sql den bize etkilenen kayıt sayısı döner, işlem başarılıysa 0 dan büyük (genelde 1) değer gelir.
            sqlCommand.Dispose(); // yoket
            connection.Close(); // bağlantıyı kapat
            return islemSonucu; // eklemeden sonra geriye işlem sonucunu döndür
        }
        public int Update(Kategori kategori)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("update kategoriler set KategoriAdi=@KategoriAdi where Id=@id", connection);

            sqlCommand.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            sqlCommand.Parameters.AddWithValue("@id", kategori.Id);

            islemSonucu = sqlCommand.ExecuteNonQuery(); // sorgu çalıştığında sql den bize etkilenen kayıt sayısı döner, işlem başarılıysa 0 dan büyük (genelde 1) değer gelir.
            sqlCommand.Dispose(); // yoket
            connection.Close(); // bağlantıyı kapat
            return islemSonucu; // eklemeden sonra geriye işlem sonucunu döndür
        }
        public Kategori Get(int id)
        {
            Kategori kategori = new Kategori();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from kategoriler where Id=@id", connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                kategori.Id = Convert.ToInt32(sqlDataReader["Id"]);
                kategori.KategoriAdi = sqlDataReader["KategoriAdi"].ToString();
            }
            sqlDataReader.Close();
            sqlCommand.Dispose(); // yoket
            connection.Close();
            return kategori;
        }
        public int Delete(int id)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("delete from kategoriler where Id=@id", connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            islemSonucu = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose(); // yoket
            connection.Close(); // bağlantıyı kapat
            return islemSonucu;
        }
    }
}
