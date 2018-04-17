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
        private string lokasi_percetakan;
        private string notelepon;

        public int Id_penerbit { get => id_penerbit; set => id_penerbit = value; }
        public string Nama_penerbit { get => nama_penerbit; set => nama_penerbit = value; }
        public string Lokasi_percetakan { get => lokasi_percetakan; set => lokasi_percetakan = value; }
        public string Notelepon { get => notelepon; set => notelepon = value; }
    }
}