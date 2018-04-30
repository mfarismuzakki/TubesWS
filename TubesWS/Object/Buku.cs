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
        private List<Penulis> penulis;
        private List<Penerbit> penerbit;
        private List<Kategori> kategori;
        private List<Bahasa> bahasa;
        private List<Deskripsi> deskripsi;

        //getset atribut
        public int Id_buku { get => id_buku; set => id_buku = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Cetakan { get => cetakan; set => cetakan = value; }
        public string Tanggalterbit { get => tanggalterbit; set => tanggalterbit = value; }
        public List<Penulis> Penulis { get => penulis; set => penulis = value; }
        public List<Penerbit> Penerbit { get => penerbit; set => penerbit = value; }
        public List<Kategori> Kategori { get => kategori; set => kategori = value; }
        public List<Bahasa> Bahasa { get => bahasa; set => bahasa = value; }
        public List<Deskripsi> Deskripsi { get => deskripsi; set => deskripsi = value; }
    }
}
