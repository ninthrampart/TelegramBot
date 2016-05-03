using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramRobot.Commands;

namespace TelegramRobot
{
    public enum CommandName { tobase64, frombase64, newguid }

    public class Command
    {
        

        string Name { get; set; }
        Dictionary<string, string> Parameters { get; set; }

        //public static Command Create(string cmdName, List<string> parameters)
        //{
        //    CommandName n = CommandName.frombase64;
        //    Command cmd;


        //    switch(cmdName)
        //    {
        //        case "/tobase64":
        //            n = CommandName.tobase64;
        //            break;
        //        case "/frombase64":
        //            n = CommandName.frombase64;
        //            break;
        //    }


        //    switch(n)
        //    {
        //        case CommandName.tobase64:
        //            return new ToBase64Command(parameters);
        //            break;
        //        case CommandName.frombase64:
        //            //throw new NotImplementedException();
        //            break;
        //    }

        //    return null;


        //}


        public static Command Create(string cmdName, string parametersString)
        {
            CommandName n = CommandName.frombase64;
            Command cmd;


            switch (cmdName)
            {
                case "/tobase64":
                    n = CommandName.tobase64;
                    break;
                case "/frombase64":
                    n = CommandName.frombase64;
                    break;
                case "/newguid":
                    n = CommandName.newguid;
                    break;
            }


            switch (n)
            {
                case CommandName.tobase64:
                    return new ToBase64Command(parametersString);
                    break;
                case CommandName.frombase64:
                    return new FromBase64Command(parametersString);
                    //throw new NotImplementedException();
                    break;
                case CommandName.newguid:
                    return new NewGuidCommand();
            }

            return null;


        }

    }
}
