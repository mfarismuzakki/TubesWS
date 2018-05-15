using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Buku")]
    public class BukuController : Controller
    {
        // GET: api/Buku
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            return Ok(buku.GetAllBuku());
        }

        // GET: api/Buku/GetByIdBuku/{Id}
        [HttpGet("GetByIdBuku/{id}", Name = "GetByIdBuku"),Authorize]
        public IActionResult GetByIdBuku(int id)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetOneBuku(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // GET: api/Buku/GetByJudulBuku/{cari}
        [HttpGet("GetByJudulBuku/{cari}", Name = "GetByJudulBuku"), Authorize]
        public IActionResult GetByJudulBuku(string cari)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetByJudulBuku(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // GET: api/Buku/GetByPenulisBuku/{cari}
        [HttpGet("GetByPenulisBuku/{cari}", Name = "GetByPenulisBuku"), Authorize]
        public IActionResult GetByPenulisBuku(string cari)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetByPenulisBuku(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // GET: api/Buku/GetByPenerbitBuku/{cari}
        [HttpGet("GetByPenerbitBuku/{cari}", Name = "GetByPenerbitBuku"), Authorize]
        public IActionResult GetByPenerbitBuku(string cari)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetByPenerbitBuku(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // GET: api/Buku/GetByBahasaBuku/{cari}
        [HttpGet("GetByBahasaBuku/{cari}", Name = "GetByBahasaBuku"), Authorize]
        public IActionResult GetByBahasaBuku(string cari)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetByBahasaBuku(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // GET: api/Buku/GetByKategoriBuku/{cari}
        [HttpGet("GetByKategoriBuku/{cari}", Name = "GetByKategoriBuku"), Authorize]
        public IActionResult GetByKategoriBuku(string cari)
        {
            Repository.RepositoryBuku buku = new Repository.RepositoryBuku();
            var temp = buku.GetByKategoriBuku(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // POST: api/Buku
        [HttpPost,Authorize]
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
        [HttpPut("{id}"),Authorize]
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
        [HttpDelete("{id}"),Authorize]
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
