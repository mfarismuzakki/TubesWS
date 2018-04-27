using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryDeskripsi
    {

        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryDeskripsi()
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
        public void InsertDeskripsi(Object.Deskripsi deskripsi)
        {
            try
            {
                string isi = deskripsi.Isi;
                int id_buku = deskripsi.Id_buku;

                string query = "insert into deskripsi values(null,'" + isi + "', '" + id_buku + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }

        }

        //get All deskripsi
        public List<Object.Deskripsi> GetAllDeskripsi()
        {
            List<Object.Deskripsi> deskripsi = new List<Object.Deskripsi>();

            try
            {
                string query = "select *from deskripsi";
                OpenConnection();

                deskripsi = connection.Query<Object.Deskripsi>(query).ToList();

                CloseConnection();
            }
            catch (Exception e)
            {

            }


            return deskripsi;
        }

        //get one deskripsi
        public Object.Deskripsi GetOneDeskripsi(int cari)
        {
            Object.Deskripsi deskripsi = new Object.Deskripsi();

            try
            {
                string query = "select *from deskripsi where id_deskripsi=" + cari;
                OpenConnection();

                deskripsi = connection.Query<Object.Deskripsi>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return deskripsi;
        }

        //update deskripsi
        public void UpdateDeskripsi(Object.Deskripsi deskripsi)
        {
            int id_deskripsi = deskripsi.Id_deskripsi;
            string isi = deskripsi.Isi;
            int id_buku = deskripsi.Id_buku;

            try
            {
                string query = "update deskripsi set id_deskripsi=" + id_deskripsi + ", isi = '" + isi + "', id_buku = '" + id_buku + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }
        }

        //delete deskripsi
        public void DeleteDeskripsi(int id)
        {

            try
            {
                string query = "delete from deskripsi where id_deskripsi= " + id;
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
