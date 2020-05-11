using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimKontrol
{
    class UretimDAL
    {
        SqlConnection connect = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog =1411008020;integrated security=true");

        public DataTable GetUretim()
        {
            
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand command = new SqlCommand("Select * from UretimTbl", connect);


            DataTable dataTable = new DataTable();

            SqlDataReader reader = command.ExecuteReader();



            dataTable.Load(reader);

            reader.Close();

            connect.Close();

            return dataTable;
        }

        public DataTable GetMakine()
        {

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand command = new SqlCommand("Select * from MakineTbl", connect);


            DataTable dataTable = new DataTable();

            SqlDataReader reader = command.ExecuteReader();



            dataTable.Load(reader);

            reader.Close();

            connect.Close();

            return dataTable;
        }

        public DataTable GetPersonel()
        {

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand command = new SqlCommand("Select * from PersonelTbl", connect);


            DataTable dataTable = new DataTable();

            SqlDataReader reader = command.ExecuteReader();



            dataTable.Load(reader);

            reader.Close();

            connect.Close();

            return dataTable;
        }

        public void UretimEkle(int urun_id, int personel_id, int makine_id, DateTime uretim_tarih, int uretim_adet)
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand sqlCommand = new SqlCommand("Insert into UretimTbl values(@UrunId,@PersonelId,@MakineId,@UretimTarih,@UretimAdet)", connect);

            sqlCommand.Parameters.AddWithValue("@UrunId", urun_id);

            sqlCommand.Parameters.AddWithValue("@PersonelId", personel_id);

            sqlCommand.Parameters.AddWithValue("@MakineId", makine_id);
            
            sqlCommand.Parameters.AddWithValue("@UretimTarih", uretim_tarih);

            sqlCommand.Parameters.AddWithValue("@UretimAdet", uretim_adet);

            sqlCommand.ExecuteNonQuery();

            connect.Close();

        }

        public void PersonelEkle(string personelAdi,string personelSoyadi)
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand sqlCommand = new SqlCommand("Insert into PersonelTbl values(@Adi,@Soyadi)", connect);

            sqlCommand.Parameters.AddWithValue("@Adi", personelAdi);

            sqlCommand.Parameters.AddWithValue("@Soyadi", personelSoyadi);


            sqlCommand.ExecuteNonQuery();

            connect.Close();

        }

        public void MakineEkle(string makineMarka,string makineAdi)
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();

            }

            SqlCommand sqlCommand = new SqlCommand("Insert into MakineTbl values(@Marka,@Adi)", connect);

            sqlCommand.Parameters.AddWithValue("@Adi", makineAdi);

            sqlCommand.Parameters.AddWithValue("@Marka", makineMarka);


            sqlCommand.ExecuteNonQuery();

            connect.Close();

        }
    }
}
