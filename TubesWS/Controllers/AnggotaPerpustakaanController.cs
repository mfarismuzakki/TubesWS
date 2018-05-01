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
        public IActionResult Get()
        {
            Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

            return Ok(anggotaperpus.GetAllAnggotaPerpustakaan());
        }

        // GET: api/AnggotaPerpustakaan/5
        [HttpGet("{id}", Name = "GetAnggotaPerpustakaan")]
        public IActionResult Get(int id)
        {
            Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();
            var temp = anggotaperpus.GetOneAnggotaPerpustakaan(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // POST: api/AnggotaPerpustakaan
        [HttpPost]
        public IActionResult Post([FromBody]Object.AnggotaPerpustakaan value)
        {
            try
            {
                //deklarasi variabel untuk post
                Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

                anggotaperpus.InsertAnggotaPerpustakaan(value);
                return Created(" ", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT: api/AnggotaPerpustakaan/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Object.AnggotaPerpustakaan value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();
                anggotaperpus.UpdateAnggotaPerpustakaan(value);
                return Created(" ", value);
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }

        // DELETE: api/AnggotaPerpustakaan/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryAnggotaPerpustakaan anggotaperpus = new Repository.RepositoryAnggotaPerpustakaan();

                //eksekusi delete
                anggotaperpus.DeleteAnggotaPerpustakaan(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
