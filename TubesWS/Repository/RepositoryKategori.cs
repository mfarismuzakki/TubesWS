using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryKategori
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryKategori()
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
        public void InsertKategori(Object.Kategori kategori)
        {
            string nama_kategori = kategori.Nama_kategori;

            using (connection)
            {
                OpenConnection();
                string query = "insert into penerbit values(null,'" + nama_kategori + "')";
                connection.Execute(query);
            }
        }

        //get All Kategori
        public List<Object.Kategori> GetAllKategori()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from kategori";
                return connection.Query<Object.Kategori>(query).ToList();
            }
        }

        //get One By Id Kategori
        public Object.Kategori GetOneKategori(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from kategori where id_kategori =" + cari;
                return connection.Query<Object.Kategori>(query, new { cari }).FirstOrDefault();

            }
        }

        //get One By Nama Kategori
        public Object.Kategori GetOneNamaKategori(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from kategori where nama_kategori =" + cari;
                return connection.Query<Object.Kategori>(query, new { cari }).FirstOrDefault();

            }
        }

        //update Kategori
        public void UpdateKategori(Object.Kategori kategori)
        {
            int id = kategori.Id_kategori;
            string nama_kategori = kategori.Nama_kategori;

            using (connection)
            {
                OpenConnection();
                string query = "update kategori set id_kategori = " + id + ", nama_kategori = '" + nama_kategori + "' where id_kategori =" + id;
                connection.Execute(query);
            }
        }

        //delete Kategori
        public void DeleteKategori(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from kategori where id_kategori = " + id;
                connection.Execute(query);
            }
            
        }

    }
}