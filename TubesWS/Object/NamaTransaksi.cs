using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class NamaTransaksi
    {
        string nama_anggota;
        string judul_buku;
        string nama_penulis;
        string tanggalpinjam;
        string tanggalkembali;
        int id_detail_peminjaman;

        public string Nama_anggota { get => nama_anggota; set => nama_anggota = value; }
        public string Judul_buku { get => judul_buku; set => judul_buku = value; }
        public string Nama_penulis { get => nama_penulis; set => nama_penulis = value; }
        public string Tanggalpinjam { get => tanggalpinjam; set => tanggalpinjam = value; }
        public string Tanggalkembali { get => tanggalkembali; set => tanggalkembali = value; }
        public int Id_detail_peminjaman { get => id_detail_peminjaman; set => id_detail_peminjaman = value; }
    }
}
