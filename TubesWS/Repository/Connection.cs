using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TubesWS.Repository
{
    public class Connection
    {
        //atribut
        MySqlConnection connection;

        public Connection()
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

    }
}
