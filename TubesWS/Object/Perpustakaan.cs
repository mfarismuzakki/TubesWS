using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Perpustakaan
    {
        //deklarasi atribut
        List<Buku> buku;

        //kontruktor
        public Perpustakaan()
        {
            Buku = new List<Buku>();
        }

        //getset buku
        public List<Buku> Buku { get => buku; set => buku = value; }
    }
}
