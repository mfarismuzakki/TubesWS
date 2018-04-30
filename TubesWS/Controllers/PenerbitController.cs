using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Penerbit")]
    public class PenerbitController : Controller
    {
        // GET: api/Penerbit
        [HttpGet]
        public IActionResult Get()
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();

            return Ok(penerbit.GetAllPenerbit());
        }

        // GET: api/Penerbit/5
        [HttpGet("{id}", Name = "GetPenerbit")]
        public IActionResult Get(int id)
        {
            Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
            var temp = penerbit.GetOnePenerbit(id);
            if (temp == null) return NotFound();
            return Ok(temp);
        }
        
        // POST: api/Penerbit
        [HttpPost]
        public string Post([FromBody]Object.Penerbit value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();

                penerbit.InsertPenerbit(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // PUT: api/Penerbit/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Penerbit value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();
                penerbit.UpdatePenerbit(value);
                return "Update berhasil";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // DELETE: api/Penerbit/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPenerbit penerbit = new Repository.RepositoryPenerbit();

                //eksekusi delete
                penerbit.DeletePenerbit(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
