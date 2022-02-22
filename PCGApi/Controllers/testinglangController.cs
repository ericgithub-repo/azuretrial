using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testinglang.Controllers
{
    [Route("pcg/[controller]")]
    [ApiController]
    public class testinglangController : ControllerBase
    {
        //private RepositoryCore.PcgTrialRepository repo;
        // GET: api/PCG
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //repo = new RepositoryCore.PcgTrialRepository();
            //var result = repo.GetPcgTrial();

            string[] result = { "yeah", "you"};

            //trial only
            return result.AsEnumerable();
        }

        // GET: api/PCG/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PCG
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PCG/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
