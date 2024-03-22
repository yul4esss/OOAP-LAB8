using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class ChatMediator
    {
        private List<IChatParticipant> participants = new List<IChatParticipant>();

        public void AddParticipant(IChatParticipant chatParticipant)
        {
            participants.Add(chatParticipant);
        }

        // Method to send message to user
        public void SendMessage(string sender, string receiver, string message)
        {
            IChatParticipant receiverParticipant = null;
            foreach (var participant in participants)
            {
                var chatUser = participant as ChatUser;
                if (chatUser != null && chatUser.UserName == receiver)
                {
                    receiverParticipant = participant;
                    break;
                }
            }

            if (receiverParticipant != null)
                receiverParticipant.ReceiveMessage(sender, message);
            else
                Console.WriteLine($"Participant {receiver} not found.");
        }

    }
}
