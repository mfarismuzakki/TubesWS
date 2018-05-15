using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace TubesWS.Repository
{
    public class RepositoryReferensi
    {
        //atribut
        MySqlConnection connection;

        //konstruktor deklarasi hak akses
        public RepositoryReferensi()
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


        //mengambil semua referensi
        public List<Object.Referensi> getAll()
        {
            //deklarasi objek referensi
            List<Object.Referensi> referensi = new List<Object.Referensi>();

            //add kamus anggota perpustakaan
            referensi.Add(new Object.Referensi { Objek = "anggotaperpustakaan", DaftarAtribut = getAnggotaPerpustakaan() });
            //add kamus bahasa
            referensi.Add(new Object.Referensi {Objek = "bahasa", DaftarAtribut = getBahasa() });
            //add kamus buku
            referensi.Add(new Object.Referensi { Objek = "buku", DaftarAtribut = getBuku() });
            //add kamus copy buku
            referensi.Add(new Object.Referensi { Objek = "copy_buku", DaftarAtribut = getCopyBuku() });
            //add kamus deskripsi
            referensi.Add(new Object.Referensi { Objek = "deskripsi", DaftarAtribut = getDeskripsi() });
            //add kamus detail detail peminjaman
            referensi.Add(new Object.Referensi { Objek = "detail peminjaman", DaftarAtribut = getDetailPeminjaman() });
            //add kamus kategori
            referensi.Add(new Object.Referensi { Objek = "kategori", DaftarAtribut = getKategori() });
            //add kamus peminjaman
            referensi.Add(new Object.Referensi { Objek = "peminjaman", DaftarAtribut = getPeminjaman() });
            //add kamus penerbit
            referensi.Add(new Object.Referensi { Objek = "penerbit", DaftarAtribut = getPenerbit() });
            //add kamus penulis
            referensi.Add(new Object.Referensi { Objek = "penulis", DaftarAtribut = getPenulis() });
            //add kamus perpustakaan
            referensi.Add(new Object.Referensi { Objek = "perpustakaan", DaftarAtribut = getPerpustakaan() });
            //add kamus pustakawan
            referensi.Add(new Object.Referensi { Objek = "pustakawan", DaftarAtribut = getPustakawan() });
            //add kamus stok buku
            referensi.Add(new Object.Referensi { Objek = "referensi", DaftarAtribut = getStokBuku() });


            return referensi;
        }
        
        //mengambil atribut di objek anggota perpustakaan
        private string getAnggotaPerpustakaan()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.AnggotaPerpustakaan data = new Object.AnggotaPerpustakaan();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for(int i = 0; i<tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if(i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek anggota perpustakaan
        private string getBahasa()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Bahasa data = new Object.Bahasa();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek buku
        private string getBuku()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Buku data = new Object.Buku();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek copy buku
        private string getCopyBuku()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Copy_buku data = new Object.Copy_buku();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek deskripsi
        private string getDeskripsi()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Deskripsi data = new Object.Deskripsi();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek detail peminjaman
        private string getDetailPeminjaman()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Detail_peminjaman data = new Object.Detail_peminjaman();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek kategori
        private string getKategori()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Kategori data = new Object.Kategori();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek peminjaman
        private string getPeminjaman()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Peminjaman data = new Object.Peminjaman();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek penerbit
        private string getPenerbit()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Penerbit data = new Object.Penerbit();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek penulis
        private string getPenulis()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Penulis data = new Object.Penulis();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek perpustakaan
        private string getPerpustakaan()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Perpustakaan data = new Object.Perpustakaan();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek pustakawan
        private string getPustakawan()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Pustakawan data = new Object.Pustakawan();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

        //mengambil atribut di objek buku
        private string getStokBuku()
        {
            string tempData = "";
            //Anggota Perpustakaan
            Object.Stok_buku data = new Object.Stok_buku();
            //penampungan objek anggota perpustakaan
            var tmp = data.GetType().GetProperties();
            for (int i = 0; i < tmp.Count(); i++)
            {
                tempData += tmp[i].Name;
                if (i != tmp.Count() - 1)
                {
                    tempData += ",";
                }
            }
            return tempData;
        }

    }
}
