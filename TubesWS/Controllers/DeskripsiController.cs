using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Deskripsi")]
    public class DeskripsiController : Controller
    {
        // GET: api/Deskripsi
        [HttpGet]
        public IEnumerable<Object.Deskripsi> Get()
        {
            //deklarasi variabel untuk return
            Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();

            //lempar hasil
            return deskripsi.GetAllDeskripsi();
        }

        // GET: api/Deskripsi/5
        [HttpGet("{id}", Name = "GetDeskripsi")]
        public Object.Deskripsi Get(int id)
        {
            //deklarais variabel untuk return
            Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();

            return deskripsi.GetOneDeskripsi(id);
        }

        // POST: api/Deskripsi
        [HttpPost]
        public string Post([FromBody]Object.Deskripsi value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();

                deskripsi.InsertDeskripsi(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }


        }

        // PUT: api/Deskripsi/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Deskripsi value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryDeskripsi deskripsi = new Repository.RepositoryDeskripsi();
                deskripsi.UpdateDeskripsi(value);
                return "Update berhasil";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
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
            catch (Exception e)
            {
                return BadRequest();
            }

        }
    }
}
