using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Copy_buku
    {
        private int id_copy_buku;
        private int id_buku;
        private int status;

        public int Id_copy_buku { get => id_copy_buku; set => id_copy_buku = value; }
        public int Id_buku { get => id_buku; set => id_buku = value; }
        public int Status { get => status; set => status = value; }
    }
}
