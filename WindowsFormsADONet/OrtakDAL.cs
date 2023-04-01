using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsADONet
{
    public class OrtakDAL
    {
        public SqlConnection connection = new SqlConnection(@"Server=.; database=AdoNetDb; trusted_connection=true"); // veritabanına bağlanmak için gerekli bağlantı nesnesi. Connectionstring: veritabanı bağlantı bilgileri
        public void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed) // veritabanı bağlantısı kapalıysa
            {
                connection.Open(); // bağlantıyı aç
            }
        }
        public DataTable GetAllDataTable(string sql)
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            table.Load(sqlDataReader); // veritabanından çekilen verileri table a yükle
            sqlDataReader.Close(); // kapat
            sqlCommand.Dispose(); // yoket
            connection.Close();
            return table;
        }
    }
}
