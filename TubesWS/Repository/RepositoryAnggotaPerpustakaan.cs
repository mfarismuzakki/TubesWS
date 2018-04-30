using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryAnggotaPerpustakaan
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryAnggotaPerpustakaan()
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
        public void InsertAnggotaPerpustakaan(Object.AnggotaPerpustakaan anggota)
        {
            string nama_anggota = anggota.Nama_anggota;
            string jenis_kelamin = anggota.Jenis_kelamin;
            string tempat_lahir = anggota.Tempat_lahir;
            string tanggal_lahir = anggota.Tanggal_lahir;
            string notelepon = anggota.Notelepon;
            string alamat = anggota.Alamat;

            using (connection)
            {
                OpenConnection();
                string query = "insert into anggotaperpustakaan values(null,'" + nama_anggota + "','" + jenis_kelamin + "','" + tempat_lahir + "','" + tanggal_lahir + "','"+ notelepon + "','" + alamat + "')";
                connection.Execute(query);
            }
        }

        //get All AnggotaPerpustakaan
        public List<Object.AnggotaPerpustakaan> GetAllAnggotaPerpustakaan()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from anggotaperpustakaan";
                return connection.Query<Object.AnggotaPerpustakaan>(query).ToList();
            }
        }

        //get One by Id AnggotaPerpustakaan
        public Object.AnggotaPerpustakaan GetOneAnggotaPerpustakaan(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from anggotaperpustakaan where id_anggota =" + cari;
                return connection.Query<Object.AnggotaPerpustakaan>(query, new { cari }).FirstOrDefault();
            }
        }

        //update AnggotaPerpustakaan
        public void UpdateAnggotaPerpustakaan(Object.AnggotaPerpustakaan anggota)
        {
            int id = anggota.Id_anggota;
            string nama_anggota = anggota.Nama_anggota;
            string jenis_kelamin = anggota.Jenis_kelamin;
            string tempat_lahir = anggota.Tempat_lahir;
            string tanggal_lahir = anggota.Tanggal_lahir;
            string no_telepon = anggota.Notelepon;
            string alamat = anggota.Alamat;
            
            using (connection)
            {
                OpenConnection();
                string query = "update anggotaperpustakaan set id_anggota=" + id + ", nama_anggota = '" + nama_anggota + "', jenis_kelamin = '" + jenis_kelamin + "', tempat_lahir = '" + tempat_lahir + "', tanggal_lahir = '" + tanggal_lahir + "', notelepon = '" + no_telepon + "', alamat = '" + alamat + "' where id_anggota =" + id;
                connection.Execute(query);
            }

        }

        //delete Penerbit
        public void DeleteAnggotaPerpustakaan(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from anggotaperpustakaan where id_anggota = " + id;
                connection.Execute(query);
            }
        }
    }
}
