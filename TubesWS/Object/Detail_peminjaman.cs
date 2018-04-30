using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Detail_peminjaman
    {
        private int id_detail_peminjaman; 
        private int id_peminjaman;
        private int id_copy_buku;

        public int Id_detail_peminjaman { get => id_detail_peminjaman; set => id_detail_peminjaman = value; }
        public int Id_peminjaman { get => id_peminjaman; set => id_peminjaman = value; }
        public int Id_copy_buku { get => id_copy_buku; set => id_copy_buku = value; }
       
    }
}