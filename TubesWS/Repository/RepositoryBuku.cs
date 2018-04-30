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
            List<Object.Penulis> penulis = new List<Object.Penulis>();
            Object.Penulis tempPenulis = new Object.Penulis();

            using (connection)
            {
                OpenConnection();
                string query = "";
                connection.Execute(query);
            }
        }

        //get All Buku
        public List<Object.Buku> GetAllBuku()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from judulbuku";
                return connection.Query<Object.Buku>(query).ToList();
            }
        }

        //get One by Id Buku
        public Object.Buku GetOneBuku(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from penerbit where id_penerbit =" + cari;
                return connection.Query<Object.Buku>(query, new { cari }).FirstOrDefault();
            }
        }

        //update Penerbit
        public void UpdatePenerbit(Object.Buku penerbit)
        {

            using (connection)
            {
                OpenConnection();
                string query = "";
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
