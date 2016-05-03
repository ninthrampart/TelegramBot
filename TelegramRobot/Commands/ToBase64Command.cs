using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramRobot.Interfaces;

namespace TelegramRobot.Commands
{
    public class ToBase64Command : Command, IExecute
    {
        string InputString { get; set; }

        //public ToBase64Command(List<string> paramteres)
        //{
        //    if(paramteres.Count > 0)
        //    {
        //        InputString = paramteres.First();
        //    }
        //}

        public ToBase64Command(string paramteres)
        {
            InputString = paramteres;
        }

        public string Execute()
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(InputString);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
