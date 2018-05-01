using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Buku")]
    public class BukuController : Controller
    {
        // GET: api/Buku
        [HttpGet]
        public IActionResult Get()
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            return Ok(buku.GetAllBuku());
        }

        // GET: api/Buku/5
        [HttpGet("{id}", Name = "GetBuku")]
        public IActionResult Get(int id)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetOneBuku(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Buku
        [HttpPost]
        public IActionResult Post([FromBody]Object.Buku value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
                buku.InsertBuku(value);
                return Created(" ", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        // PUT: api/Buku/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Object.Buku value)
        {
            try
            {
                Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
                buku.UpdateBuku(value);
                return Created(" ", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
                buku.DeleteBuku(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
