using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Repository
{
    public class RepositoryUser
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryUser()
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
        public void InsertUser(Object.User user)
        {
            string username = user.Username;
            string password = user.Password;

            using (connection)
            {
                OpenConnection();
                string query = "insert into user values(null,'" + username + "','" + password + "')";
                connection.Execute(query);
            }

        }

        //get All User
        public List<Object.User> GetAllUser()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from user";
                return connection.Query<Object.User>(query).ToList();
            }

        }

        //get One By Nama User
        public Object.User GetByNamaUser(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select *from user where username ='" + cari +"'";
                return connection.Query<Object.User>(query, new { cari }).FirstOrDefault();
            }

        }

        //update User
        public void UpdateUser(Object.User user)
        {
            int id_user = user.Id_user;
            string username = user.Username;
            string password = user.Password;


            using (connection)
            {
                OpenConnection();
                string query = "update user set id_user =" + id_user + ", username =" + username + ", password =" + password + "";
                connection.Execute(query);
            }

        }

        //delete User
        public void DeleteUser(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from user where id_user = " + id;
                connection.Execute(query);
            }

        }
    }
}
