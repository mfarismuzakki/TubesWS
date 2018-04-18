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
        public void InsertKategori(Object.Kategori kategori)
        {
            try
            {
                string nama_kategori = kategori.Nama_kategori;

                string query = "insert into penerbit values(null,'" + nama_kategori + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }

        }

        //get All penulis
        public List<Object.Kategori> GetAllKategori()
        {
            List<Object.Kategori> kategori = new List<Object.Kategori>();

            try
            {
                string query = "select *from kategori";
                OpenConnection();

                kategori = connection.Query<Object.Kategori>(query).ToList();

                CloseConnection();
            }
            catch (Exception e)
            {

            }


            return kategori;
        }

        //get one penulis
        public Object.Kategori GetOneKategori(int cari)
        {
            Object.Kategori kategori = new Object.Kategori();

            try
            {
                string query = "select *from kategori where id_kategori =" + cari;
                OpenConnection();

                kategori = connection.Query<Object.Kategori>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return kategori;
        }

        //update penulis
        public void UpdateKategori(Object.Kategori kategori)
        {
            int id = kategori.Id_kategori;
            string nama_kategori = kategori.Nama_kategori;

            try
            {
                string query = "update kategori set id_kategori = " + id + ", nama_kategori = '" + nama_kategori + "' where id_kategori =" + id;
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }
        }

        //delete penulis
        public void DeleteKategori(int id)
        {

            try
            {
                string query = "delete from kategori where id_kategori = " + id;
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }
        }

    }
}