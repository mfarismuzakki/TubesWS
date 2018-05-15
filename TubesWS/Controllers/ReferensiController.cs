using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Referensi")]
    public class ReferensiController : Controller
    {
        // GET: api/Referensi
        [HttpGet]
        public IEnumerable<Object.Referensi> Get()
        {
            Repository.RepositoryReferensi referensi = new Repository.RepositoryReferensi();
            return referensi.getAll();
        }

        // GET: api/Referensi/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Referensi
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Referensi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
