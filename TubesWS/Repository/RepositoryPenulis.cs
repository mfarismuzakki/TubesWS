using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryPenulis
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryPenulis()
        {
            connection = new MySqlConnection("server=localhost;Database=perpustakaan;Uid=root");
        }

        //membuka koneksi
        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }catch(Exception e)
            {

            }
        }

        //menutup koneksi
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }catch(Exception e)
            {

            }
        }

        //memasukan input ke database
        public void InsertPenulis(Object.Penulis penulis)
        {
            try
            {
                string nama_penulis = penulis.Nama_penulis;
                string tempat_lahir = penulis.Tempat_lahir;
                string tanggal_lahir = penulis.Tanggal_lahir;
                string domisili = penulis.Domisili;

                string query = "insert into penulis values(null,'" + nama_penulis + "','" + tempat_lahir + "','" + tanggal_lahir + "','" + domisili + "')";
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }catch(Exception e)
            {

            }
           
        }

        //get All penulis
        public List<Object.Penulis> GetAllPenulis()
        {
            List<Object.Penulis> penulis = new List<Object.Penulis>();

            try
            {
                string query = "select *from penulis";
                OpenConnection();

                penulis = connection.Query<Object.Penulis>(query).ToList();

                CloseConnection();
            }catch(Exception e)
            {

            }
           

            return penulis;
        }

        //get one penulis
        public Object.Penulis GetOnePenulis(int cari)
        {
            Object.Penulis penulis = new Object.Penulis();

            try
            {
                string query = "select *from penulis where id_penulis ="+cari;
                OpenConnection();

                penulis = connection.Query<Object.Penulis>(query, new {cari}).FirstOrDefault();

                CloseConnection();
            }catch(Exception e)
            {

            }

            return penulis;
        }

        //update penulis
        public void UpdatePenulis(Object.Penulis penulis)
        {
            int id = penulis.Id_penulis;
            string nama_penulis = penulis.Nama_penulis;
            string tempat_lahir = penulis.Tempat_lahir;
            string tanggal_lahir = penulis.Tanggal_lahir;
            string domisili = penulis.Domisili;

            try
            {
                string query = "update penulis set id_penulis=" + id + ", nama_penulis = '" + nama_penulis + "', tempat_lahir = '" + tempat_lahir + "', tanggal_lahir = '" + tanggal_lahir + "', domisili = '" + domisili + "' where id_penulis =" + id;
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }catch(Exception e)
            {

            }
        }

        //delete penulis
        public void DeletePenulis(int id)
        {
            
            try
            {
                string query = "delete from penulis where id_penulis = " + id;
                OpenConnection();

                connection.Execute(query);

                CloseConnection();
            }catch(Exception e)
            {

            }
        }

    }
}
