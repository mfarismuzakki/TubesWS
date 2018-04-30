using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Pustakawan
    {
        private int id_pustakawan;
        private string nama_pustakawan;
        private string jenis_kelamin;
        private string tempat_lahir;
        private string tanggal_lahir;
        private string notelepon;
        private string alamat;

        public int Id_pustakawan { get => id_pustakawan; set => id_pustakawan = value; }
        public string Nama_pustakawan { get => nama_pustakawan; set => nama_pustakawan = value; }
        public string Jenis_kelamin { get => jenis_kelamin; set => jenis_kelamin = value; }
        public string Tempat_lahir { get => tempat_lahir; set => tempat_lahir = value; }
        public string Tanggal_lahir { get => tanggal_lahir; set => tanggal_lahir = value; }
        public string Notelepon { get => notelepon; set => notelepon = value; }
        public string Alamat { get => alamat; set => alamat = value; }
    }
}
