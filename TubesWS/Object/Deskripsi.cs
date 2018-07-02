using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Deskripsi
    {
        private int id_deskripsi;
        private string isi;
        private int id_buku;
        private string judul_buku;

        public int Id_deskripsi { get => id_deskripsi; set => id_deskripsi = value; }
        public string Isi { get => isi; set => isi = value; }
        public int Id_buku { get => id_buku; set => id_buku = value; }
        public string Judul_buku { get => judul_buku; set => judul_buku = value; }
    }
}
