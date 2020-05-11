using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimKontrol
{
    class UrunlerDAL
    {
        SqlConnection connect = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog =1411008020;integrated security=true");

        public DataTable GetUrunler()
        {
            
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand command = new SqlCommand("Select * from UrunTbl", connect);


            DataTable dataTable = new DataTable();

            SqlDataReader reader = command.ExecuteReader();



            dataTable.Load(reader);

            reader.Close();

            connect.Close();

            return dataTable;
        }

        public void UrunEkle(string UrunAdi , string Kategori)
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand sqlCommand = new SqlCommand("Insert into UrunTbl values(@UrunAdi,@Kategori)",connect);

            sqlCommand.Parameters.AddWithValue("@UrunAdi", UrunAdi);

            sqlCommand.Parameters.AddWithValue("@Kategori", Kategori);

            sqlCommand.ExecuteNonQuery();

            connect.Close();

        }
    }
}
