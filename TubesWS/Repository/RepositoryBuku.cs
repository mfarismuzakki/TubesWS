using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryBuku
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryBuku()
        {
            connection = new MySqlConnection("server=localhost;Database=perpustakaan;Uid=root");
        }

        //membuka koneksi
        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {

            }
        }

        //menutup koneksi
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {

            }
        }

        //memasukan input ke database
        public void InsertBuku(Object.Buku buku)
        {
            string judul = buku.Judul;
            int cetakan = buku.Cetakan;
            string tanggalterbit = buku.Tanggalterbit;

            using (connection)
            {
                OpenConnection();
                string query = "";
                connection.Execute(query);
            }
        }

        //get All Penerbit
        public List<Object.Penerbit> GetAllPenerbit()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from penerbit";
                return connection.Query<Object.Penerbit>(query).ToList();
            }
        }

        //get One by Id Penerbit
        public Object.Penerbit GetOnePenerbit(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from penerbit where id_penerbit =" + cari;
                return connection.Query<Object.Penerbit>(query, new { cari }).FirstOrDefault();
            }
        }

        //update Penerbit
        public void UpdatePenerbit(Object.Penerbit penerbit)
        {
            int id = penerbit.Id_penerbit;
            string nama_penerbit = penerbit.Nama_penerbit;
            string lokasi_percetakan = penerbit.Lokasi_percetakan;
            string notelepon = penerbit.Notelepon;

            using (connection)
            {
                OpenConnection();
                string query = "update penerbit set id_penerbit=" + id + ", nama_penerbit = '" + nama_penerbit + "', lokasi_penerbit = '" + lokasi_percetakan + "', notelepon = '" + notelepon + "' where id_penerbit =" + id;
                connection.Execute(query);
            }

        }

        //delete Penerbit
        public void DeletePenerbit(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from penerbit where id_penerbit = " + id;
                connection.Execute(query);
            }
        }
    }
}
