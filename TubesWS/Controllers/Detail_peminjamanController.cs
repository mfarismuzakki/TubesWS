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
        public IEnumerable<Object.Detail_peminjaman> Get()
        {
            Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

            return detail_peminjaman.GetAllDetail_peminjaman();
        }

        // GET: api/Detail_peminjaman/5
        [HttpGet("{id}", Name = "GetDetail_peminjaman")]
        public Object.Detail_peminjaman Get(int id)
        {
            Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

            return detail_peminjaman.GetOneDetail_peminjaman(id);
        }
        
        // POST: api/Detail_peminjaman
        [HttpPost]
        public string Post([FromBody]Object.Detail_peminjaman value)
        {
            try
            {
                //deklarasi variavel untuk post
                Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

                detail_peminjaman.InsertDetail_peminjaman(value);
                return "Data Berhasil Diinput";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // PUT: api/Detail_eminjaman/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Object.Detail_peminjaman value)
        {
            try
            {
                //deklarasi variabel untuk update
                Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();
                detail_peminjaman.UpdateDetail_peminjaman(value);
                return "Update berhasil";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        // DELETE: api/Detail_peminjaman/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            try
            {
                //deklarasi variabel untuk delete
                Repository.RepositoryDetail_peminjaman detail_peminjaman = new Repository.RepositoryDetail_peminjaman();

                //eksekusi delete
                detail_peminjaman.DeleteDetail_peminjaman(id);

                return "Delete berhasil";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
