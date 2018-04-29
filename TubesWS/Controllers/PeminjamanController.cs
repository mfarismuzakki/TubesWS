using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Peminjaman")]
    public class PeminjamanController : Controller
    {
        // GET: api/Peminjaman
        [HttpGet]
        public IEnumerable<Object.Peminjaman> Get()
        {
            Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

            return peminjaman.GetAllPeminjaman();
        }

        // GET: api/Peminjaman/5
        [HttpGet("{id}", Name = "GetPeminjaman")]
        public Object.Peminjaman Get(int id)
        {
            Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

            return peminjaman.GetOnePeminjaman(id);
        }
        
        // POST: api/Peminjaman
        [HttpPost]
        public string Post([FromBody]Object.Peminjaman value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

                peminjaman.InsertPeminjaman(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // PUT: api/Peminjaman/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Peminjaman value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();
                peminjaman.UpdatePeminjaman(value);
                return "Update berhasil";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // DELETE: api/Peminjaman/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

                //eksekusi delete
                peminjaman.DeletePeminjaman(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
