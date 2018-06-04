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
    [Route("api/Penerbit")]
    public class PenerbitController : Controller
    {
        // GET: api/Penerbit
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();

            return Ok(penerbit.GetAllPenerbit());
        }

        // GET: api/Penerbit/GetByIdPenerbit/{id}
        [HttpGet("GetByIdPenerbit/{id}", Name = "GetByIdPenerbit"),Authorize]
        public IActionResult GetByIdPenerbit(int id)
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
            var temp = penerbit.GetOnePenerbit(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Penerbit/GetByNamaPenerbit/{cari}
        [HttpGet("GetByNamaPenerbit/{cari}", Name = "GetByNamaPenerbit"),Authorize]
        public IActionResult GetByNamaPenerbit(string cari)
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
            var temp = penerbit.GetOneNamaPenerbit(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Penerbit/GetByLokasiPercetakan/{cari}
        [HttpGet("GetByLokasiPercetakan/{cari}", Name = "GetByLokasiPercetakan"),Authorize]
        public IActionResult GetByLokasiPercetakan(string cari)
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
            var temp = penerbit.GetByLokasiPercetakan(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Penerbit/GetByNoKontak/{cari}
        [HttpGet("GetByNoKontak/{cari}", Name = "GetByNoKontak"),Authorize]
        public IActionResult GetByNoKontak(string cari)
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
            var temp = penerbit.GetByNoKontak(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Penerbit
        [HttpPost,Authorize]
        public IActionResult Post([FromBody]Object.Penerbit value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();

                penerbit.InsertPenerbit(value);
                return Created("Data Berhasil Diinput", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        // PUT: api/Penerbit/5
        [HttpPut("{id}"),Authorize]
        public IActionResult Put(int id, [FromBody]Object.Penerbit value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
                penerbit.UpdatePenerbit(value);
                return Created("Update berhasil", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        // DELETE: api/Penerbit/5
        [HttpDelete("{id}"),Authorize]
        public IActionResult Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();

                //eksekusi delete
                penerbit.DeletePenerbit(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
