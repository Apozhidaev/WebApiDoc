using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDoc.Tests.Modules.Api.Controllers
{
    [RoutePrefix("api")]
    public class IndexController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "bo");
        }
    }
}