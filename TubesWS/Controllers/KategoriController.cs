using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Kategori")]
    public class KategoriController : Controller
    {
        // GET: api/Kategori
        [HttpGet]
        public IEnumerable<Object.Kategori> Get()
        {
            Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

            return kategori.GetAllKategori();
        }

        // GET: api/Kategori/5
        [HttpGet("{id}", Name = "GetKategori")]
        public Object.Kategori Get(int id)
        {
            Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

            return kategori.GetOneKategori(id);
        }
        
        // POST: api/Kategori
        [HttpPost]
        public string Post([FromBody]Object.Kategori value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

                kategori.InsertKategori(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // PUT: api/Kategori/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Kategori value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

                kategori.UpdateKategori(value);
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
                Repository.RepositoryKategori kategori = new Repository.RepositoryKategori();

                //eksekusi delete
                kategori.DeleteKategori(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
