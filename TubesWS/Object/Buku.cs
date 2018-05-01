using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Buku
    {
        //deklarasi atribut
        private int id_buku;
        private string judul;
        private int cetakan;
        private string tanggalterbit;
        private string penulis;
        private string penerbit;
        private string kategori;
        private string bahasa;

        //getset atribut
        public int Id_buku { get => id_buku; set => id_buku = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Cetakan { get => cetakan; set => cetakan = value; }
        public string Tanggalterbit { get => tanggalterbit; set => tanggalterbit = value; }
        public string Penulis { get => penulis; set => penulis = value; }
        public string Penerbit { get => penerbit; set => penerbit = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
    }
}
