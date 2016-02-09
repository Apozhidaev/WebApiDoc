using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace WebApiDoc.Tests.Modules.Api.Controllers
{
    [RoutePrefix("help")]
    public class HelpController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            var res = new JObject
            {
                {"Hello", "Welcome to the test service"},
                {"Description", DocHelper.GetControllerInfo(typeof(IndexController))}
            };
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}