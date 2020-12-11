using System.Collections.Generic;
using System.Web.Http;

namespace LV2_kusevic_API.Controllers
{
    public class ContactController : ApiController
    {
        // GET api/contact
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }


    }
}
