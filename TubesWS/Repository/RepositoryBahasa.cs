using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryBahasa
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryBahasa()
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
        public void InsertBahasa(Object.Bahasa bahasa)
        {
            string nama_bahasa = bahasa.Nama_bahasa;

            using (connection)
            {
                OpenConnection();
                string query = "insert into bahasa values(null,'" + nama_bahasa + "')";
                connection.Execute(query);
            }
            
        }

        //get All Bahasa
        public List<Object.Bahasa> GetAllBahasa()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from bahasa";
                return connection.Query<Object.Bahasa>(query).ToList();
            }
            
        }

        //get One By Id Bahasa
        public Object.Bahasa GetOneBahasa(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from bahasa where id_bahasa=" + cari;
                 return connection.Query<Object.Bahasa>(query, new { cari }).FirstOrDefault();
            }
            
        }

        //get One By Id Bahasa
        public Object.Bahasa GetOneNamaBahasa(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from bahasa where nama_bahasa=" + cari;
                return connection.Query<Object.Bahasa>(query, new { cari }).FirstOrDefault();
            }

        }

        //update Bahasa
        public void UpdateBahasa(Object.Bahasa bahasa)
        {
            int id = bahasa.Id_bahasa;
            string nama_bahasa = bahasa.Nama_bahasa;

            using (connection)
            {
                OpenConnection();
                string query = "update bahasa set id_bahasa=" + id + ", nama_bahasa = " + nama_bahasa + "";
                connection.Execute(query);
            }
            
        }

        //delete Bahasa
        public void DeleteBahasa(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from bahasa where id_bahasa= " + id;
                connection.Execute(query);
            }
            
        }
    }
}
