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
    [Route("api/Pustakawan")]
    public class PustakawanController : Controller
    {
        // GET: api/Pustakawan
        [HttpGet,Authorize]
        public IActionResult Get()
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

            return Ok(pustakawan.GetAllPustakawan());
        }

        // GET: api/Pustakawan/5
        [HttpGet("{id}", Name = "GetPustakawan"),Authorize]
        public IActionResult Get(int id)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetOnePustakawan(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Pustakawan/GetByNamaPustakawan/{cari}
        [HttpGet("GetByNamaPustakawan/{cari}", Name = "GetByNamaPustakawan"), Authorize]
        public IActionResult GetByNamaPustakawan(string cari)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetByNamaPustakawan(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Pustakawan/GetByJenisKelamin/{cari}
        [HttpGet("GetByJenisKelamin/{cari}", Name = "GetByJenisKelamin"), Authorize]
        public IActionResult GetByJenisKelamin(string cari)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetByJenisKelamin(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Pustakawan/GetByTempatLahir/{cari}
        [HttpGet("GetByTempatLahir/{cari}", Name = "GetByTempatLahir"), Authorize]
        public IActionResult GetByTempatLahir(string cari)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetByTempatLahir(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		
		// GET: api/Pustakawan/GetByTanggalLahir/{cari}
        [HttpGet("GetByTanggalLahir/{cari}", Name = "GetByTanggalLahir"), Authorize]
        public IActionResult GetByTanggalLahir(string cari)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetByTanggalLahir(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Pustakawan/GetByNoTelepon/{cari}
        [HttpGet("GetByNoTelepon/{cari}", Name = "GetByNoTelepon"), Authorize]
        public IActionResult GetByNoTelepon(string cari)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetByNoTelepon(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
		// GET: api/Pustakawan/GetByAlamat/{cari}
        [HttpGet("GetByAlamat/{cari}", Name = "GetByAlamat"), Authorize]
        public IActionResult GetByAlamat(string cari)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
            var temp = pustakawan.GetByAlamat(cari);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
		
        // POST: api/Pustakawan
        [HttpPost,Authorize]
        public IActionResult Post([FromBody]Object.Pustakawan value)
        {
            try
            {
                //deklarasi variabel untuk post
                Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

                pustakawan.InsertPustakawan(value);
                return Created("", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT: api/Pustakawan/5
        [HttpPut("{id}"),Authorize]
        public IActionResult Put(int id, [FromBody]Object.Pustakawan value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
                pustakawan.UpdatePustakawan(value);
                return Created("", value);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE: api/Pustakawan/5
        [HttpDelete("{id}"),Authorize]
        public IActionResult Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

                //eksekusi delete
                pustakawan.DeletePustakawan(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
