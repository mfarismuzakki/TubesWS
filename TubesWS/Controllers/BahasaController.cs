using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Bahasa")]
    public class BahasaController : Controller
    {
        // GET: api/Bahasa
        [HttpGet]
        public IEnumerable<Object.Bahasa> Get()
        {
            //deklarasi variabel untuk return
            Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

            //lempar hasil
            return bahasa.GetAllBahasa();
        }

        // GET: api/Bahasa/5
        [HttpGet("{id}", Name = "GetBahasa")]
        public Object.Bahasa Get(int id)
        {
            //deklarais variabel untuk return
            Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

            return bahasa.GetOneBahasa(id);
        }

        // POST: api/Bahasa
        [HttpPost]
        public string Post([FromBody]Object.Bahasa value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

                bahasa.InsertBahasa(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }


        }

        // PUT: api/Bahasa/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Bahasa value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();
                bahasa.UpdateBahasa(value);
                return "Update berhasil";

            }
            catch (Exception e)
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
                Repository.RepositoryBahasa bahasa = new Repository.RepositoryBahasa();

                //eksekusi delete
                bahasa.DeleteBahasa(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
