using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/AnggotaPerpustakaan")]
    public class AnggotaPerpustakaanController : Controller
    {
        // GET: api/AnggotaPerpustakaan
        [HttpGet]
        public IEnumerable<Object.AnggotaPerpustakaan> Get()
        {
            Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

            return anggotaperpus.GetAllAnggotaPerpustakaan();
        }

        // GET: api/AnggotaPerpustakaan/5
        [HttpGet("{id}", Name = "GetAnggotaPerpustakaan")]
        public Object.AnggotaPerpustakaan Get(int id)
        {
            Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

            return anggotaperpus.GetOneAnggotaPerpustakaan(id);
        }

        // POST: api/AnggotaPerpustakaan
        [HttpPost]
        public string Post([FromBody]Object.AnggotaPerpustakaan value)
        {
            try
            {
                //deklarasi variabel untuk post
                Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

                anggotaperpus.InsertAnggotaPerpustakaan(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // PUT: api/AnggotaPerpustakaan/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.AnggotaPerpustakaan value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();
                anggotaperpus.UpdateAnggotaPerpustakaan(value);
                return "Update berhasil";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // DELETE: api/AnggotaPerpustakaan/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

                //eksekusi delete
                anggotaperpus.DeleteAnggotaPerpustakaan(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
