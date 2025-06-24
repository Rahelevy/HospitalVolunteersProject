using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Route("api/volunteer")]
    public class VolunteerController : ApiController
    {
        VolunteerBLL volunteerBLL= new VolunteerBLL();

        [Route("VolunteersByAddress/{address}"), HttpGet]

        public IHttpActionResult VolunteersByAddress(string address)
        {
            var res=volunteerBLL.VolunteersByAddress(address);
            if (res == null)          
                return NotFound();
            return Ok(res);          
        }

        // GET: api/Volunteer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Volunteer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Volunteer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Volunteer/5
        public void Delete(int id)
        {
        }
    }
}
