using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KardexGPS.Api.Models;

namespace KardexGPS.Api
{
    [RoutePrefix("api/user/{userId:int}")]
    public class UserController : ApiController
    {
        [HttpPost, Route("")]
        public HttpResponseMessage Post(int userId, [FromBody] UserModels.GenericUser UserData)
        {
            return Request.CreateResponse(HttpStatusCode.OK,new { Status="Saved" });
        }
    }
}
