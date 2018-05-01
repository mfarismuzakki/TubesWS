using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryCopyBuku
    {

        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryCopyBuku()
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
        public void InsertCopyBuku(Object.Copy_buku copy)
        {
            int id_buku = copy.Id_buku;

            using (connection)
            {
                OpenConnection();
                string query = "insert into copy_buku values(null,'" + id_buku + "')";
                connection.Execute(query);
            }

        }

        //get All Copy Buku
        public List<Object.Copy_buku> GetAllCopyBuku()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from copy_buku";
                return connection.Query<Object.Copy_buku>(query).ToList();
            }

        }

        //get One By Id Copy Buku
        public Object.Copy_buku GetOneCopyBuku(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from copy_buku where id_copy_buku=" + cari;
                return connection.Query<Object.Copy_buku>(query, new { cari }).FirstOrDefault();
            }

        }

        //update Copy Buku
        public void UpdateCopyBuku(Object.Copy_buku copy)
        {
            int id_copy_buku = copy.Id_copy_buku;
            int id_buku = copy.Id_buku;

            using (connection)
            {
                OpenConnection();
                string query = "update copy_buku set id_copy_buku =" + id_copy_buku + ", id_buku =" + id_buku + "";
                connection.Execute(query);
            }

        }

        //delete Copy Buku
        public void DeleteCopyBuku(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from copy_buku where id_copy_buku = " + id;
                connection.Execute(query);
            }

        }
    }
}
