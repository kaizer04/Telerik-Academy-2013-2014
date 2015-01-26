namespace BunnyCraft.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;

    // Cors
    // [EnableCors(origins: "http://telerikacademy.com", headers: "*", methods: "GET,POST")]
    public class TestsController : ApiController
    {
        [HttpPost]
        public object CreateTest(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            return new
            {
                TestName = name
            };
        }
    }
}
