using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Kategori
    {
        private int id_kategori;
        private string nama_kategori;

        public int Id_kategori { get => id_kategori; set => id_kategori = value; }
        public string Nama_kategori { get => nama_kategori; set => nama_kategori = value; }
    }
}
