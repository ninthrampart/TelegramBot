using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramRobot.Interfaces;

namespace TelegramRobot.Commands
{
    public class NewGuidCommand : Command, IExecute
    {
        public string Execute()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
