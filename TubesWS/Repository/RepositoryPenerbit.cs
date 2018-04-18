using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryPenerbit
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryPenerbit()
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
        public void InsertPenerbit(Object.Penerbit penerbit)
        {
            try
            {
                string nama_penerbit = penerbit.Nama_penerbit;
                string lokasi_percetakan = penerbit.Lokasi_percetakan;
                string notelepon = penerbit.Notelepon;

                string query = "insert into penerbit values(null,'" + nama_penerbit + "','" + lokasi_percetakan + "','" + notelepon + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }

        }

        //get All penulis
        public List<Object.Penerbit> GetAllPenerbit()
        {
            List<Object.Penerbit> penerbit = new List<Object.Penerbit>();

            try
            {
                string query = "select *from penerbit";
                OpenConnection();

                penerbit = connection.Query<Object.Penerbit>(query).ToList();

                CloseConnection();
            }
            catch (Exception e)
            {

            }


            return penerbit;
        }

        //get one penulis
        public Object.Penerbit GetOnePenerbit(int cari)
        {
            Object.Penerbit penerbit = new Object.Penerbit();

            try
            {
                string query = "select *from penerbit where id_penerbit =" + cari;
                OpenConnection();

                penerbit = connection.Query<Object.Penerbit>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return penerbit;
        }

        //update penulis
        public void UpdatePenerbit(Object.Penerbit penerbit)
        {
            int id = penerbit.Id_penerbit;
            string nama_penerbit = penerbit.Nama_penerbit;
            string lokasi_percetakan = penerbit.Lokasi_percetakan;
            string notelepon = penerbit.Notelepon;

            try
            {
                string query = "update penerbit set id_penerbit=" + id + ", nama_penerbit = '" + nama_penerbit + "', lokasi_penerbit = '" + lokasi_percetakan + "', notelepon = '" + notelepon + "' where id_penerbit =" + id;
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }
            catch (Exception e)
            {

            }
        }

        //delete penulis
        public void DeletePenerbit(int id)
        {

            try
            {
                string query = "delete from penerbit where id_penerbit = " + id;
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