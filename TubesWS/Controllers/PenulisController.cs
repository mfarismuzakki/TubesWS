using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Penulis")]
    public class PenulisController : Controller
    {
        // GET: api/Penulis
        [HttpGet]
        public IEnumerable<Object.Penulis> Get()
        {
            //deklarasi variabel untuk return
            Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

            //lempar hasil
            return penulis.GetAllPenulis();
        }

        // GET: api/Penulis/5
        [HttpGet("{id}", Name = "GetPenulis")]
        public Object.Penulis Get(int id)
        {
            //deklarais variabel untuk return
            Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

            return penulis.GetOnePenulis(id);
        }
        
        // POST: api/Penulis
        [HttpPost]
        public string Post([FromBody]Object.Penulis value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

                penulis.InsertPenulis(value);
                return "Data Berhasil Diinput";
            }catch(Exception e)
            {
                return e.Message;
            }
            

        }
        
        // PUT: api/Penulis/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Penulis value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();
                penulis.UpdatePenulis(value);
                return "Update berhasil";

            }catch(Exception e)
            {
                return e.Message;
            }
            
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryPenulis penulis = new Repository.RepositoryPenulis();

                //eksekusi delete
                penulis.DeletePenulis(id);

                return "Delete berhasil";
            }catch(Exception e)
            {
                return e.Message;
            }
           
        }
    }
}
