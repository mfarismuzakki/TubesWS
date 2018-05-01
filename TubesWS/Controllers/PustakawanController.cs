using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Pustakawan")]
    public class PustakawanController : Controller
    {
        // GET: api/Pustakawan
        [HttpGet]
        public IEnumerable<Object.Pustakawan> Get()
        public IActionResult Get()
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

            return pustakawan.GetAllPustakawan();
        }

        // GET: api/Pustakawan/5
        [HttpGet("{id}", Name = "GetPustakawan")]
        public Object.Pustakawan Get(int id)
        {
            Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

            return pustakawan.GetOnePustakawan(id);
        }

        // POST: api/Pustakawan
        [HttpPost]
        public string Post([FromBody]Object.Pustakawan value)
        {
            try
            {
                //deklarasi variabel untuk post
                Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

                pustakawan.InsertPustakawan(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // PUT: api/Pustakawan/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Pustakawan value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();
                pustakawan.UpdatePustakawan(value);
                return "Update berhasil";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // DELETE: api/Pustakawan/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPustakawan pustakawan = new Repository.RepositoryPustakawan();

                //eksekusi delete
                pustakawan.DeletePustakawan(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
