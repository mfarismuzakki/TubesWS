using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryPustakawan
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryPustakawan()
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
        public void InsertPustakawan(Object.Pustakawan pustakawan)
        {
            string nama_pustakawan = pustakawan.Nama_pustakawan;
            string jenis_kelamin = pustakawan.Jenis_kelamin;
            string tempat_lahir = pustakawan.Tempat_lahir;
            string tanggal_lahir = pustakawan.Tanggal_lahir;
            string notelepon = pustakawan.Notelepon;
            string alamat = pustakawan.Alamat;

            using (connection)
            {
                OpenConnection();
                string query = "insert into pustakawan values(null,'" + nama_pustakawan + "','" + jenis_kelamin + "','" + tempat_lahir + "','" + tanggal_lahir + "','"+ notelepon + "','" + alamat + "')";
                connection.Execute(query);
            }
        }

        //get All Pustakawan
        public List<Object.Pustakawan> GetAllPustakawan()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from pustakawan";
                return connection.Query<Object.Pustakawan>(query).ToList();
            }
        }

        //get One by Id Pustakawan
        public Object.Pustakawan GetOnePustakawan(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from pustakawan where id_pustakawan =" + cari;
                return connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();
            }
        }
		
		//get by nama pustakawan
        public Object.Pustakawan GetByNamaPustakawan(string cari)
        {
            Object.Pustakawan pustakawan = new Object.Pustakawan();

            try
            {
                string query = "select *from pustakawan where nama_pustakawan LIKE '%" + cari + "%'";
                OpenConnection();

                pustakawan = connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return pustakawan;
        }
		
		//get by Jenis kelamin
        public Object.Pustakawan GetByJenisKelamin(string cari)
        {
            Object.Pustakawan pustakawan = new Object.Pustakawan();

            try
            {
                string query = "select *from pustakawan where jenis_kelamin LIKE '%" + cari + "%'";
                OpenConnection();

                pustakawan = connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return pustakawan;
        }
		
		//get by tempat lahir
        public Object.Pustakawan GetByTempatLahir(string cari)
        {
            Object.Pustakawan pustakawan = new Object.Pustakawan();

            try
            {
                string query = "select *from pustakawan where tempat_lahir LIKE '%" + cari + "%'";
                OpenConnection();

                pustakawan = connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return pustakawan;
        }
		
		//get by tanggal lahir
        public Object.Pustakawan GetByTanggalLahir(string cari)
        {
            Object.Pustakawan pustakawan = new Object.Pustakawan();

            try
            {
                string query = "select *from pustakawan where tanggal_lahir LIKE '%" + cari + "%'";
                OpenConnection();

                pustakawan = connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return pustakawan;
        }
		
		//get by No Telepon
        public Object.Pustakawan GetByNoTelepon(string cari)
        {
            Object.Pustakawan pustakawan = new Object.Pustakawan();

            try
            {
                string query = "select *from pustakawan where notelepon LIKE '%" + cari + "%'";
                OpenConnection();

                pustakawan = connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return pustakawan;
        }
		
		//get by alamat
        public Object.Pustakawan GetByAlamat(string cari)
        {
            Object.Pustakawan pustakawan = new Object.Pustakawan();

            try
            {
                string query = "select *from pustakawan where alamat LIKE '%" + cari + "%'";
                OpenConnection();

                pustakawan = connection.Query<Object.Pustakawan>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return pustakawan;
        }

        //update Pustakawan
        public void UpdatePustakawan(Object.Pustakawan pustakawan)
        {
            int id = pustakawan.Id_pustakawan;
            string nama_pustakawan = pustakawan.Nama_pustakawan;
            string jenis_kelamin = pustakawan.Jenis_kelamin;
            string tempat_lahir = pustakawan.Tempat_lahir;
            string tanggal_lahir = pustakawan.Tanggal_lahir;
            string no_telepon = pustakawan.Notelepon;
            string alamat = pustakawan.Alamat;
            
            using (connection)
            {
                OpenConnection();
                string query = "update pustakawan set id_pustakawan=" + id + ", nama_pustakawan = '" + nama_pustakawan + "', jenis_kelamin = '" + jenis_kelamin + "', tempat_lahir = '" + tempat_lahir + "', tanggal_lahir = '" + tanggal_lahir + "', notelepon = '" + no_telepon + "', alamat = '" + alamat + "' where id_pustakawan =" + id;
                connection.Execute(query);
            }

        }

        //delete Penerbit
        public void DeletePustakawan(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from pustakawan where id_pustakawan = " + id;
                connection.Execute(query);
            }
        }
    }
}
