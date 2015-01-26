using BunnyCraft.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace BunnyCraft.Services.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}

        // DEMO
        // GET api/values
        //public IEnumerable<string> Post(PeshoInputModel input)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        return new string[] { "value1", "value2" };
        //    }

        //    throw new ArgumentException();

        //}

        //[Queryable]
        //[EnableQuery] // for v4
        // GET api/values
        public IQueryable<string> Get()
        {
            return this.GetData().AsQueryable();
        }

        // GET api/values
        //public IHttpActionResult Get(int input)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        throw new HttpRequestException("Invalid data");
        //    }

        //    return Ok(this.GetData());

        //}

        // api/values/somename/{id}
        [HttpGet]
        public string[] SomeName()
        {
            return new string[] { "Name", "AnotherName" };
        }

        private string[] GetData()
        {
            return new string[] { "value1", "value2", "pesho" };
        }
    }
}
