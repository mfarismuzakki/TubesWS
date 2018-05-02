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
    [Route("api/Penulis")]
    public class PenulisController : Controller
    {
        // GET: api/Penulis
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            //deklarasi variabel untuk return
            Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

            //lempar hasil
            return Ok(penulis.GetAllPenulis());
        }

        // GET: api/Penulis/5
        [HttpGet("{id}", Name = "GetPenulis"),Authorize]
        public IActionResult Get(int id)
        {
            //deklarais variabel untuk return
            Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();
            var temp = penulis.GetOnePenulis(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Penulis
        [HttpPost,Authorize]
        public IActionResult Post([FromBody]Object.Penulis value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

                penulis.InsertPenulis(value);
                return Created("", value);
            }catch(Exception)
            {
                return BadRequest();
            }
            

        }
        
        // PUT: api/Penulis/5
        [HttpPut("{id}"),Authorize]
        public IActionResult Put(int id, [FromBody]Object.Penulis value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();
                penulis.UpdatePenulis(value);
                return Created("", value);

            }catch(Exception)
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
                Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

                //eksekusi delete
                penulis.DeletePenulis(id);

                return Ok();
            }catch(Exception)
            {
                return BadRequest();
            }
           
        }
    }
}
