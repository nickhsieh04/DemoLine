using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ServiceApi.Contorllers
{
    public class LineController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> POST()
        {
            return null;
        }

        [HttpGet]
        public string Demo()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
