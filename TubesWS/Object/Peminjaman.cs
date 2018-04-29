using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Peminjaman
    {
        private int id_peminjaman;
        private int id_anggota; 
        private int id_pustakawan;
        private string tanggalpinjam;
		private string tanggalkembali;

        public int Id_peminjaman { get => id_peminjaman; set => id_peminjaman = value; }
        public int Id_anggota { get => id_anggota; set => id_anggota = value; }
        public int Id_pustakawan { get => id_pustakawan; set => id_pustakawan = value; }
        public string Tanggalpinjam { get => tanggalpinjam; set => tanggalpinjam = value; }
		public string Tanggalkembali { get => tanggalkembali; set => tanggalkembali = value; }
    }
}