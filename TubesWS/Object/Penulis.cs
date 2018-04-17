using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Penulis
    {
        //atribut
        private int id_penulis;
        private string nama_penulis;
        private string tempat_lahir;
        private string tanggal_lahir;
        private string domisili;

        //getset
        public int Id_penulis { get => id_penulis; set => id_penulis = value; }
        public string Nama_penulis { get => nama_penulis; set => nama_penulis = value; }
        public string Tempat_lahir { get => tempat_lahir; set => tempat_lahir = value; }
        public string Tanggal_lahir { get => tanggal_lahir; set => tanggal_lahir = value; }
        public string Domisili { get => domisili; set => domisili = value; }
    }
}
