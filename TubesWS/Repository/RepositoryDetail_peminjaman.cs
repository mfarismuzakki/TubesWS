using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryDetail_peminjaman
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryDetail_peminjaman()
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
        public void InsertDetail_peminjaman(Object.Detail_peminjaman detail_peminjaman)
        {
            int id_peminjaman = detail_peminjaman.Id_peminjaman;
            int id_buku = detail_peminjaman.Id_buku;

            using (connection)
            {
                OpenConnection();
                string query = "insert into detail_peminjaman values(null,'" + id_peminjaman + "','" + id_buku + "')";
                connection.Execute(query);
            }
        }

        //get All Detail_Peminjaman
        public List<Object.Detail_peminjaman> GetAllDetail_peminjaman()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from detail_peminjaman";
                return connection.Query<Object.Detail_peminjaman>(query).ToList();
            }
        }

        //get One by Id Detail_peminjaman
        public Object.Detail_peminjaman GetOneDetail_peminjaman(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from detail_peminjaman where id_detail_peminjaman =" + cari;
                return connection.Query<Object.Detail_peminjaman>(query, new { cari }).FirstOrDefault();
            }
        }

        //update Detail_peminjaman
        public void UpdateDetail_peminjaman(Object.Detail_peminjaman detail_peminjaman)
        {
            int id = detail_peminjaman.Id_detail_peminjaman;
			int id_peminjaman = detail_peminjaman.Id_peminjaman;
            int id_buku = detail_peminjaman.Id_buku;

            using (connection)
            {
                OpenConnection();
                string query = "update detail_peminjaman set id_detail_peminjaman=" + id + ", id_peminjaman = '" + id_peminjaman + "', id_buku = '" + id_buku + "' where id_detail_peminjaman =" + id;
                connection.Execute(query);
            }
            
        }

        //delete Detail_peminjaman
        public void DeleteDetail_peminjaman(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from detail_peminjaman where id_detail_peminjaman = " + id;
                connection.Execute(query);
            }
        }

    }
}