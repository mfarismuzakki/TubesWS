using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Detail_peminjaman")]
    public class Detail_peminjamanController : Controller
    {
        // GET: api/Detail_peminjaman
        [HttpGet]
        public IActionResult Get()
        {
            Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

            return Ok(detail_peminjaman.GetAllDetail_peminjaman());
        }

        // GET: api/Detail_peminjaman/5
        [HttpGet("{id}", Name = "GetDetail_peminjaman")]
        public IActionResult Get(int id)
        {
            Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();
            var temp = detail_peminjaman.GetOneDetail_peminjaman(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Detail_peminjaman
        [HttpPost]
        public IActionResult Post([FromBody]Object.Detail_peminjaman value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

                detail_peminjaman.InsertDetail_peminjaman(value);
                return Created("", value);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        // PUT: api/Detail_eminjaman/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Object.Detail_peminjaman value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();
                detail_peminjaman.UpdateDetail_peminjaman(value);
                return Created("", value);

            }
            catch (Exception )
            {
                return BadRequest();
            }
        }
        
        // DELETE: api/Detail_peminjaman/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

                //eksekusi delete
                detail_peminjaman.DeleteDetail_peminjaman(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
