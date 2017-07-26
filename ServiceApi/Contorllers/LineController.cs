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
        //public async Task<IHttpActionResult> POST()
        public IHttpActionResult POST()
        {
            string ChannelAccessToken = "787a3b276bff601936fbfb9aaef73554";
            try
            {
                string postData = Request.Content.ReadAsStringAsync().Result;

                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);

                string Messages;
                Messages = "你說了:" + ReceivedMessage.events[0].message.text;

                isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Messages, ChannelAccessToken);

                return Ok();
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }

        [HttpGet]
        public string Demo()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
