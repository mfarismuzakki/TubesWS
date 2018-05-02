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
    [Route("api/Deskripsi")]
    public class DeskripsiController : Controller
    {
        // GET: api/Deskripsi
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            //deklarasi variabel untuk return
            Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();

            //lempar hasil
            return Ok(deskripsi.GetAllDeskripsi());
        }

        // GET: api/Deskripsi/5
        [HttpGet("{id}", Name = "GetDeskripsi"),Authorize]
        public IActionResult Get(int id)
        {
            //deklarais variabel untuk return
            Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();
            var temp = deskripsi.GetOneDeskripsi(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }

        // POST: api/Deskripsi
        [HttpPost,Authorize]
        public IActionResult Post([FromBody]Object.Deskripsi value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();

                deskripsi.InsertDeskripsi(value);
                return Created("", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }


        }

        // PUT: api/Deskripsi/5
        [HttpPut("{id}"),Authorize]
        public IActionResult Put(int id, [FromBody]Object.Deskripsi value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();
                deskripsi.UpdateDeskripsi(value);
                return Created("", value);
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
                //deklarasi variabel untuk delete
                Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();

                //eksekusi delete
                deskripsi.DeleteDeskripsi(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
