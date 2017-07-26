using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Diagnostics;

namespace ServiceApi.Contorllers
{
    public class LineController : ApiController
    {
        [HttpPost]
        //public async Task<IHttpActionResult> POST()
        public IHttpActionResult POST()
        {
            string ChannelAccessToken = "787a3b276bff601936fbfb9aaef73554";
            try
            {
                string postData = Request.Content.ReadAsStringAsync().Result;
                Trace.TraceInformation("postData:" + postData);

                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);

                string Messages;
                Messages = "你說了:" + ReceivedMessage.events[0].message.text;

                isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Messages, ChannelAccessToken);

                return Ok();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Ok();
            }
        }

        [HttpGet]
        public string Demo()
        {
            Trace.TraceInformation("call Demo ...");
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
