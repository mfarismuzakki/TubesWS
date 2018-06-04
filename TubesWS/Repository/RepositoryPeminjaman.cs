using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryPeminjaman
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryPeminjaman()
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
        public void InsertPeminjaman(Object.Peminjaman peminjaman)
        {
            int id_anggota = peminjaman.Id_anggota;
            int id_pustakawan = peminjaman.Id_pustakawan;
            string tanggalpinjam = peminjaman.Tanggalpinjam;
			string tanggalkembali = peminjaman.Tanggalkembali;

            using (connection)
            {
                OpenConnection();
                string query = "insert into peminjaman values(null,'" + id_anggota + "','" + id_pustakawan + "','" + tanggalpinjam + "','" + tanggalkembali + "')";
                connection.Execute(query);
            }
        }

        //get All Peminjaman
        public List<Object.Peminjaman> GetAllPeminjaman()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from peminjaman";
                return connection.Query<Object.Peminjaman>(query).ToList();
            }
        }

        public int GetID()
        {
            using (connection)
            {
                OpenConnection();

                string query = "select last_insert_id();SELECT SCOPE_IDENTITY()";

                MySqlCommand cmd = new MySqlCommand(query,connection);
                int data =Convert.ToInt32(cmd.ExecuteScalar());
                return data;
            }
        }

        //get One by Id Peminjaman
        public Object.Peminjaman GetOnePeminjaman(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from peminjaman where id_peminjaman =" + cari;
                return connection.Query<Object.Peminjaman>(query, new { cari }).FirstOrDefault();
            }
        }

        //update Penerbit
        public void UpdatePeminjaman(Object.Peminjaman peminjaman)
        {
            int id = peminjaman.Id_peminjaman;
			int id_anggota = peminjaman.Id_anggota;
            int id_pustakawan = peminjaman.Id_pustakawan;
            string tanggalpinjam = peminjaman.Tanggalpinjam;
            string tanggalkembali = peminjaman.Tanggalkembali;

            using (connection)
            {
                OpenConnection();
                string query = "update peminjaman set id_peminjaman=" + id + ", id_anggota = '" + id_anggota + "', id_pustakawan = '" + id_pustakawan + "', tanggalpinjam = '" + tanggalpinjam + "', tanggalkembali = '" + tanggalkembali + "' where id_peminjaman =" + id;
                connection.Execute(query);
            }
            
        }

        //delete Penerbit
        public void DeletePeminjaman(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from peminjaman where id_peminjaman = " + id;
                connection.Execute(query);
            }
        }

    }
}