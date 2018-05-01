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
        public IActionResult Get()
        {
            Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

            return Ok(peminjaman.GetAllPeminjaman());
        }

        // GET: api/Peminjaman/5
        [HttpGet("{id}", Name = "GetPeminjaman")]
        public IActionResult Get(int id)
        {
            Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();
            var temp = peminjaman.GetOnePeminjaman(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Peminjaman
        [HttpPost]
        public IActionResult Post([FromBody]Object.Peminjaman value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

                peminjaman.InsertPeminjaman(value);
                return Created("", value);
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }
        
        // PUT: api/Peminjaman/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Object.Peminjaman value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();
                peminjaman.UpdatePeminjaman(value);
                return Created("", value);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        // DELETE: api/Peminjaman/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPeminjaman peminjaman = new Repository.RepositoryPeminjaman();

                //eksekusi delete
                peminjaman.DeletePeminjaman(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
