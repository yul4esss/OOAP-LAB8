using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class ChatUser : IChatParticipant
    {
        public string UserName { get; private set; }
        private ChatMediator chatMediator;

        public ChatUser(string userName, ChatMediator chatMediator)
        {
            this.UserName = userName;
            this.chatMediator = chatMediator;
        }

        public void SendMessage(string receiver, string message)
        {
            chatMediator.SendMessage(UserName, receiver, message);
        }

        public void ReceiveMessage(string sender, string message)
        {
            Console.WriteLine($"{UserName} received a message from {sender}: {message}");
        }
    }
}
