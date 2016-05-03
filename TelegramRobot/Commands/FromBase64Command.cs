using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramRobot.Interfaces;

namespace TelegramRobot.Commands
{
    public class FromBase64Command : Command, IExecute
    {
        string InputString { get; set; }

        public FromBase64Command(string paramteres)
        {
            InputString = paramteres;
        }

        public string Execute()
        {
            var bytes = Convert.FromBase64String(InputString);
            string plainText = System.Text.Encoding.UTF8.GetString(bytes);
            //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(InputString);
            return plainText;
        }
    }
}
