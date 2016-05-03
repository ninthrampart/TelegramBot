using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramRobot
{
    public class Robot
    {

        public Command ParseCommand(string messageText)
        {
            Command cmd = new Command();

            int cmdIndex = messageText.IndexOf('/');

            if (cmdIndex != -1)
            {
                string substr1 = messageText.Substring(cmdIndex);

                var p = substr1.Split(' ');

                //List<string> prs = new List<string>();
                string prs = "";
                if(p.Length > 1)
                {
                    prs = p[1];
                    for(int i = 2; i < p.Length; i++)
                    {
                        prs += " " + p[i];
                    }

                    //prs.Add(p[1]);
                }

                cmd = Command.Create(p[0], prs);

            }
            else
                return null;
            
            
            return cmd;
        }

    }
}
