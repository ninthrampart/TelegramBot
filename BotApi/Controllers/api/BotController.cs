using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Telegram.Bot.Types;

namespace BotApi.Controllers.api
{
    [RoutePrefix("api/bot")]
    public class BotController : ApiController
    {
        private Telegram.Bot.Api Bot;

        public BotController()
        {
            Bot = new Telegram.Bot.Api("207074898:AAELQj4ybCMIDfQ7z7jHqP1bbJIO1QvLc_I");
        }

        [HttpGet]
        [Route("ProcessMessage2")]
        public IHttpActionResult Post2()
        {
            Update update = null;
            return Ok();
        }

        [HttpPost]
        [Route("ProcessMessage")]
        public async Task<IHttpActionResult> Post(Update update)
        {
            
            //Update update = null;
            var message = update.Message;

            Console.WriteLine("Received Message from {0}", message.Chat.Id);

            if (message.Type == MessageType.TextMessage)
            {
                // Echo each Message
                //await Bot.SendTextMessage(message.Chat.Id, message.Text);
                await Bot.SendTextMessage(message.Chat.Id, "Got it");
            }
            else if (message.Type == MessageType.PhotoMessage)
            {
                // Download Photo
                //var file = await Bot.GetFile(message.Photo.LastOrDefault()?.FileId);

                //var filename = file.FileId + "." + file.FilePath.Split('.').Last();

                //using (var saveImageStream = File.Open(filename, FileMode.Create))
                //{
                //    await file.FileStream.CopyToAsync(saveImageStream);
                //}

                //await Bot.SendTextMessage(message.Chat.Id, "Thx for the Pics");

                await Bot.SendTextMessage(message.Chat.Id, "Unsupported message type");
            }

            return Ok();
        }
    }
}
