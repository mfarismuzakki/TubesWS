using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryStokBuku
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryStokBuku()
        {
            connection = new MySqlConnection("server=localhost;Database=perpustakaan;Uid=root;SslMode=none");
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
        public void InsertStokBuku(Object.Stok_buku stok_buku)
        {
            int id_buku = stok_buku.Id_buku;
            int stok = stok_buku.Stok;

            using (connection)
            {
                OpenConnection();
                string query = "insert into stok_buku values(null,'" + id_buku + "','" + stok + "')";
                connection.Execute(query);
            }

        }

        //get All Stok Buku
        public List<Object.Stok_buku> GetAllStokBuku()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from stok_buku";
                return connection.Query<Object.Stok_buku>(query).ToList();
            }

        }

        //get One By Id Stok Buku
        public Object.Stok_buku GetOneStokBuku(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from stok_buku where id_stok_buku=" + cari;
                return connection.Query<Object.Stok_buku>(query, new { cari }).FirstOrDefault();
            }

        }

        //update Stok Buku
        public void UpdateStokBuku(Object.Stok_buku stok_buku)
        {
            int id_stok_buku = stok_buku.Id_stok_buku;
            int id_buku = stok_buku.Id_buku;
            int stok = stok_buku.Stok;

            using (connection)
            {
                OpenConnection();
                string query = "update stok_buku set id_stok_buku =" + id_stok_buku + ", id_buku =" + id_buku + ", stok =" + stok + "";
                connection.Execute(query);
            }

        }

        //delete Stok Buku
        public void DeleteStokBuku(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from stok_buku where id_stok_buku = " + id;
                connection.Execute(query);
            }

        }
    }
}
