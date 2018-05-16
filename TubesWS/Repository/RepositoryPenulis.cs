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
            connection = new MySqlConnection("server=localhost;Database=perpustakaan;Uid=root;SslMode=none");
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
            string nama_penulis = penulis.Nama_penulis;
            string tempat_lahir = penulis.Tempat_lahir;
            string tanggal_lahir = penulis.Tanggal_lahir;
            string domisili = penulis.Domisili;

            using (connection)
            {
                OpenConnection();
                string query = "insert into penulis values(null,'" + nama_penulis + "','" + tempat_lahir + "','" + tanggal_lahir + "','" + domisili + "')";
                connection.Execute(query);
            }
            
        }

        //get All penulis
        public List<Object.Penulis> GetAllPenulis()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from penulis";
                return connection.Query<Object.Penulis>(query).ToList();
            }
            
        }

        //get One By id penulis
        public Object.Penulis GetOnePenulis(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from penulis where id_penulis =" + cari;
                return connection.Query<Object.Penulis>(query, new { cari }).FirstOrDefault();
            }
            
        }

        //get One By nama penulis
        public Object.Penulis GetOneNamaPenulis(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from penulis where nama_penulis =" + cari;
                return connection.Query<Object.Penulis>(query, new { cari }).FirstOrDefault();
            }

        }
		
		
		//get by tempat lahir
        public Object.Penulis GetByTempatLahir(string cari)
        {
            Object.Penulis penulis = new Object.Penulis();

            try
            {
                string query = "select *from penulis where tempat_lahir LIKE '%" + cari + "%'";
                OpenConnection();

                penulis = connection.Query<Object.Penulis>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return penulis;
        }
		
		//get by tanggal lahir
        public Object.Penulis GetByTanggalLahir(string cari)
        {
            Object.Penulis penulis = new Object.Penulis();

            try
            {
                string query = "select *from penulis where tanggal_lahir LIKE '%" + cari + "%'";
                OpenConnection();

                penulis = connection.Query<Object.Penulis>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
            {

            }

            return penulis;
        }
		
		//get by domisili
        public Object.Penulis GetByDomisili(string cari)
        {
            Object.Penulis penulis = new Object.Penulis();

            try
            {
                string query = "select *from penulis where domisili LIKE '%" + cari + "%'";
                OpenConnection();

                penulis = connection.Query<Object.Penulis>(query, new { cari }).FirstOrDefault();

                CloseConnection();
            }
            catch (Exception e)
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

            using (connection)
            {
                OpenConnection();
                string query = "update penulis set id_penulis=" + id + ", nama_penulis = '" + nama_penulis + "', tempat_lahir = '" + tempat_lahir + "', tanggal_lahir = '" + tanggal_lahir + "', domisili = '" + domisili + "' where id_penulis =" + id;
                connection.Execute(query);
            }
            
        }

        //delete penulis
        public void DeletePenulis(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from penulis where id_penulis = " + id;
                connection.Execute(query);
            }
            
        }
    }
}
