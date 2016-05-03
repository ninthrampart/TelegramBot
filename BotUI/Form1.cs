using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramRobot;
using TelegramRobot.Interfaces;

namespace BotUI
{
    public partial class Form1 : Form
    {
        private Telegram.Bot.Api Bot;
        private int lastUpdateId = 0;

        public Form1()
        {
            InitializeComponent();
            Bot = new Telegram.Bot.Api("207074898:AAELQj4ybCMIDfQ7z7jHqP1bbJIO1QvLc_I");
            
        }

        private void btnTestBot_Click(object sender, EventArgs e)
        {
            Bot = new Telegram.Bot.Api("207074898:AAELQj4ybCMIDfQ7z7jHqP1bbJIO1QvLc_I");
            var me = Bot.GetMe().Result;
            //System.Console.WriteLine("Hello my name is " + me.FirstName);
            //var updates = Bot.GetUpdates(0).Result;
        }

        private void btnGetUpdates_Click(object sender, EventArgs e)
        {
            //if(lastUpdateId != 0)
            //{
            //    lastUpdateId++;
            //}
                    
            var updates = Bot.GetUpdates(lastUpdateId).Result;
            //var lastUpdate = updates.LastOrDefault();

            //if(lastUpdate != null)
            //{
            //    lastUpdateId = lastUpdate.Id;

            //}

            foreach(var update in updates)
            {
                if(update.Message.Type == Telegram.Bot.Types.MessageType.TextMessage)
                {
                    txtMessages.Text += Environment.NewLine + update.Message.Text;
                }

                Robot r = new Robot();
                var cmd = r.ParseCommand(update.Message.Text);
                if(cmd != null)
                {
                    string res = ((IExecute)cmd).Execute();
                    Bot.SendTextMessage("45220090", res);
                }
                lastUpdateId = update.Id + 1;
            }

            //lastUpdateId++;


        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {            
            var t = Bot.SendTextMessage("45220090", "!!!!!!").Result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lastUpdateId != 0)
            {                
                var updates = Bot.GetUpdates(lastUpdateId).Result;
            }
        }
    }
}
