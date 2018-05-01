using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Stok_buku
    {
        private int id_stok_buku;
        private int id_buku;
        private int stok;

        public int Id_stok_buku { get => id_stok_buku; set => id_stok_buku = value; }
        public int Id_buku { get => id_buku; set => id_buku = value; }
        public int Stok { get => stok; set => stok = value; }
    }
}
