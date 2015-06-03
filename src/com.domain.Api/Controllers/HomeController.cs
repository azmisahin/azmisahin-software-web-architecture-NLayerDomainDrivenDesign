using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.domain.Api.Controllers
{
    public class HomeController : ApiController
    {
        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            var result = new string[] { "one", "two", "three" };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
            return response;
        }
        
        /// <summary>
        /// Get All By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(int id)
        {
            var result = new string[] { "one", "two", "three" };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
        
        /// <summary>
        /// Post Update
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
            if (ModelState.IsValid)
            {
                var result = value;
            }
        }

        /// <summary>
        /// Put Create a New
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
            if (ModelState.IsValid)
            {
                var result = value;
            }
        }
        
        /// <summary>
        /// Delete By Id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            System.Diagnostics.Trace.WriteLine(id);
        }
    }
}