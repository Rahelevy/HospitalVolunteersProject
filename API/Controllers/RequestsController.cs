using BLL;
using DTO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace API.Controllers
{
    [Route("api/requests")]
    public class RequestsController : ApiController
    {
        HelpRequestBLL helpRequestBLL = new HelpRequestBLL();
        RequestsBLL requestsBLL = new RequestsBLL();
        AssignedRequestsBLL assignedRequestsBLL = new AssignedRequestsBLL();

        // 1
        [Route("GetAssignedRequestsById/{id}"), HttpGet]
        public IHttpActionResult GetAssignedRequestsById(int id)
        {
            if (id <= 0)
                return NotFound();

            var res = assignedRequestsBLL.GetAssignedRequestsByIdVolunteer(id);
            if (res == null)
                return NotFound();

            return Ok(res);
        }

        // 2 
        [Route("UnapprovedRequests"), HttpGet]
        public IHttpActionResult UnapprovedRequests()
        {
            var res = requestsBLL.UnapprovedRequests();
            if (res == null)
                return NotFound();
            return Ok(res);
        }

        // 3
        [Route("MostUnapprovedRequests"), HttpGet]
        public IHttpActionResult MostUnapprovedRequests()
        {
            var res = helpRequestBLL.MostUnapprovedRequests();
            if (res == null)
                return NotFound();
            return Ok(res);
        }

        // 4
        [Route("GetApprovedRequestsInfo"), HttpGet]

        public IHttpActionResult GetApprovedRequestsInfo()
        {
            try
            {
                var res = requestsBLL.GetApprovedRequestsInfo();
                if (res == null)
                    return NotFound();
                return Ok(res);
            }
            catch
            {
                return InternalServerError();
            }

        }

        // 5
        [Route("GetRequestsMostHelped/{idvol}"), HttpGet]

        public IHttpActionResult GetRequestsMostHelped(int idvol)
        {
            try
            {
                var res = requestsBLL.GetRequestsMostHelped(idvol);
                if (res == null)
                    return NotFound();
                return Ok(res);
            }
            catch
            {
                return InternalServerError();
            }
        }

        // 6 
        [Route("GetRequestsPerVolunteer"), HttpGet]
        public IHttpActionResult GetRequestsPerVolunteer()
        {
            try
            {
                var res = requestsBLL.GetRequestsPerVolunteer();
                if (res == null)
                    return NotFound();
                return Ok(res);
            }
            catch
            {
                return InternalServerError();
            }
        }

        // POST: api/Requests
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Requests/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Requests/5
        public void Delete(int id)
        {
        }
    }
}
