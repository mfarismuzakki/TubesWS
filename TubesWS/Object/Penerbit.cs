using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TubesWS.Object
{
    public class Penerbit
    {
        private int id_penerbit;
        private string nama_penerbit; 
        private string lokasipercetakan;
        private string notelepon;

        public int Id_penerbit { get => id_penerbit; set => id_penerbit = value; }
        public string Nama_penerbit { get => nama_penerbit; set => nama_penerbit = value; }
        public string Lokasipercetakan { get => lokasipercetakan; set => lokasipercetakan = value; }
        public string Notelepon { get => notelepon; set => notelepon = value; }
    }
}