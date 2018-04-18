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
        public void InsertBahasa(Object.Bahasa bahasa)
        {
            try
            {
                string nama_bahasa = bahasa.Nama_bahasa;

                string query = "insert into bahasa values(null,'" + nama_bahasa + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }

        }

        //get All penulis
        public List<Object.Bahasa> GetAllBahasa()
        {
            List<Object.Bahasa> bahasa = new List<Object.Bahasa>();

            try
            {
                string query = "select *from bahasa";
                OpenConnection();

                bahasa = connection.Query<Object.Bahasa>(query).ToList();

                CloseConnection();
            }
            catch (Exception e)
            {

            }


            return bahasa;
        }

        //get one penulis
        public Object.Bahasa GetOneBahasa(int cari)
        {
            Object.Bahasa penulis = new Object.Bahasa();

            try
            {
                string query = "select *from bahasa where id_bahasa=" + cari;
                OpenConnection();

                penulis = connection.Query<Object.Bahasa>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return penulis;
        }

        //update penulis
        public void UpdateBahasa(Object.Bahasa bahasa)
        {
            int id = bahasa.Id_bahasa;
            string nama_bahasa = bahasa.Nama_bahasa;
            
            try
            {
                string query = "update bahasa set id_bahasa=" + id + ", nama_bahasa = '" + nama_bahasa + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }
        }

        //delete penulis
        public void DeleteBahasa(int id)
        {

            try
            {
                string query = "delete from bahasa where id_bahasa= " + id;
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
