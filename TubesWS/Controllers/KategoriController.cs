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
    [Route("api/Kategori")]
    public class KategoriController : Controller
    {
        // GET: api/Kategori
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

            return Ok(kategori.GetAllKategori());
        }

        // GET: api/Kategori/5
        [HttpGet("{id}", Name = "GetKategori"),Authorize]
        public IActionResult Get(int id)
        {
            Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();
            var temp = kategori.GetOneKategori(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Kategori
        [HttpPost,Authorize]
        public IActionResult Post([FromBody]Object.Kategori value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

                kategori.InsertKategori(value);
                return Created("", value);
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }
        
        // PUT: api/Kategori/5
        [HttpPut("{id}"),Authorize]
        public IActionResult Put(int id, [FromBody]Object.Kategori value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

                kategori.UpdateKategori(value);
                return Created("", value);

            }
            catch (Exception )
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
                //deklarasi variabel untuk delete
                Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

                //eksekusi delete
                kategori.DeleteKategori(id);

                return Ok();
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }
    }
}
