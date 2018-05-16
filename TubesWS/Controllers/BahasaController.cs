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
    [Route("api/Bahasa")]
    public class BahasaController : Controller
    {
        // GET: api/Bahasa
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            //deklarasi variabel untuk return
            Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

            //lempar hasil
            return Ok(bahasa.GetAllBahasa());
        }

        // GET: api/Bahasa/5
        [HttpGet("{id}", Name = "GetBahasa"), Authorize]
        public IActionResult Get(int id)
        {
            //deklarais variabel untuk return
            Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();
            var temp = bahasa.GetOneBahasa(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // GET: api/Bahasa/GetOneNamaBahasa/{cari}
        [HttpGet("GetOneNamaBahasa/{cari}", Name = "GetOneNamaBahasa"), Authorize]
        public IActionResult GetByNamaBahasa(string cari)
        {
            Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();
            var temp = bahasa.GetOneNamaBahasa(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // POST: api/Bahasa
        [HttpPost, Authorize]
        public IActionResult Post([FromBody]Object.Bahasa value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

                bahasa.InsertBahasa(value);
                return Created(" ", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT: api/Bahasa/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(int id, [FromBody]Object.Bahasa value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();
                bahasa.UpdateBahasa(value);
                return Created(" ", value);

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}"), Authorize]
        public IActionResult Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

                //eksekusi delete
                bahasa.DeleteBahasa(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}