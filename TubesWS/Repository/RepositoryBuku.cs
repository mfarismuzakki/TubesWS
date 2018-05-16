using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryBuku
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryBuku()
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
        public void InsertBuku(Object.Buku buku)
        {
            string judul = buku.Judul;
            int cetakan = buku.Cetakan;
            string tanggalterbit = buku.Tanggalterbit;

            RepositoryPenulis tempRepoPenulis = new RepositoryPenulis();
            Object.Penulis tempPenulis = new Object.Penulis();
            tempPenulis =  tempRepoPenulis.GetOneNamaPenulis(buku.Penulis);

            RepositoryPenerbit tempRepoPenerbit = new RepositoryPenerbit();
            Object.Penerbit tempPenerbit = new Object.Penerbit();
            tempPenerbit = tempRepoPenerbit.GetOneNamaPenerbit(buku.Penerbit);

            RepositoryKategori tempRepoKategori = new RepositoryKategori();
            Object.Kategori tempKategori = new Object.Kategori();
            tempKategori = tempRepoKategori.GetOneNamaKategori(buku.Kategori);

            RepositoryBahasa tempRepoBahasa = new RepositoryBahasa();
            Object.Bahasa tempBahasa = new Object.Bahasa();
            tempBahasa = tempRepoBahasa.GetOneNamaBahasa(buku.Bahasa);

            using (connection)
            {
                OpenConnection();
                string query = "insert into judulbuku values(null,'" + judul + "','" + cetakan + "','" + tanggalterbit + "','" + tempPenulis.Id_penulis + "','" + tempPenerbit.Id_penerbit + "','" + tempKategori.Id_kategori + "','" + tempBahasa.Id_bahasa + "')";
                connection.Execute(query);
            }
        }

        //get All Buku
        public List<Object.Buku> GetAllBuku()
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori))";
                return connection.Query<Object.Buku>(query).ToList();
            }
        }

        //get One by Id Buku
        public List<Object.Buku> GetOneBuku(int cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori)) and " +
                    "judulbuku.id_buku ='" + cari + "'";
                return connection.Query<Object.Buku>(query, new { cari }).ToList();
                //FirstOrDefault()
            }
        }

        //get by Judul Buku
        public List<Object.Buku> GetByJudulBuku(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori)) and " +
                    "judulbuku.judul_buku LIKE '%" + cari +"%'";
                return connection.Query<Object.Buku>(query, new { cari }).ToList();
            }
        }

        //get by Penulis Buku
        public List<Object.Buku> GetByPenulisBuku(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori)) and " +
                    "penulis.nama_penulis LIKE '%" + cari + "%'";
                return connection.Query<Object.Buku>(query, new { cari }).ToList();
            }
        }

        //get by Penerbit Buku
        public List<Object.Buku> GetByPenerbitBuku(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori)) and " +
                    "penerbit.nama_penerbit LIKE '%" + cari + "%'";
                return connection.Query<Object.Buku>(query, new { cari }).ToList();
            }
        }

        //get by Bahasa Buku
        public List<Object.Buku> GetByBahasaBuku(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori)) and " +
                    "bahasa.nama_bahasa LIKE '%" + cari + "%'";
                return connection.Query<Object.Buku>(query, new { cari }).ToList();
            }
        }

        //get by Kategori Buku
        public List<Object.Buku> GetByKategoriBuku(string cari)
        {
            using (connection)
            {
                OpenConnection();
                string query = "select judulbuku.id_buku AS `id_buku`," +
                    "judulbuku.judul_buku AS `judul`," +
                    "judulbuku.cetakan AS `cetakan`," +
                    "judulbuku.tanggalterbit AS `tanggalterbit`," +
                    "penulis.nama_penulis AS `penulis`," +
                    "penerbit.nama_penerbit AS `penerbit`," +
                    "bahasa.nama_bahasa AS `bahasa`," +
                    "kategori.nama_kategori AS `kategori`" +
                    " from ((((`judulbuku` join `penulis`) join `penerbit`) join `bahasa`) join `kategori`)" +
                    " where ((judulbuku.id_penulis = penulis.id_penulis) and" +
                    " (judulbuku.id_penerbit = penerbit.id_penerbit) and" +
                    " (judulbuku.id_bahasa = bahasa.id_bahasa) and" +
                    " (judulbuku.id_kategori = kategori.id_kategori)) and " +
                    "kategori.nama_kategori LIKE '%" + cari + "%'";
                return connection.Query<Object.Buku>(query, new { cari }).ToList();
            }
        }

        //update Buku
        public void UpdateBuku(Object.Buku buku)
        {
            int id_buku = buku.Id_buku;
            string judul = buku.Judul;
            int cetakan = buku.Cetakan;
            string tanggalterbit = buku.Tanggalterbit;

            RepositoryPenulis tempRepoPenulis = new RepositoryPenulis();
            Object.Penulis tempPenulis = new Object.Penulis();
            tempPenulis = tempRepoPenulis.GetOneNamaPenulis(buku.Penulis);

            RepositoryPenerbit tempRepoPenerbit = new RepositoryPenerbit();
            Object.Penerbit tempPenerbit = new Object.Penerbit();
            tempPenerbit = tempRepoPenerbit.GetOneNamaPenerbit(buku.Penerbit);


            RepositoryKategori tempRepoKategori = new RepositoryKategori();
            Object.Kategori tempKategori = new Object.Kategori();
            tempKategori = tempRepoKategori.GetOneNamaKategori(buku.Kategori);

            RepositoryBahasa tempRepoBahasa = new RepositoryBahasa();
            Object.Bahasa tempBahasa = new Object.Bahasa();
            tempBahasa = tempRepoBahasa.GetOneNamaBahasa(buku.Bahasa);

            using (connection)
            {
                OpenConnection();
                string query = "update judulbuku set id_buku ='" + id_buku + "', judul ='" + judul + "', cetakan ='" + cetakan + "', tanggalterbit ='" + tanggalterbit + "', id_penulis ='" + tempPenulis.Id_penulis + "', id_penerbit ='" + tempPenerbit.Id_penerbit + "', id_kategori ='" + tempKategori.Id_kategori + "', id_bahasa ='" + tempBahasa.Id_bahasa + "' where id_buku ='" + id_buku + "'";
                connection.Execute(query);
            }

        }

        //delete Buku
        public void DeleteBuku(int id)
        {
            using (connection)
            {
                OpenConnection();
                string query = "delete from judulbuku where id_buku = '" + id +"'";
                connection.Execute(query);
            }
        }
    }
}
