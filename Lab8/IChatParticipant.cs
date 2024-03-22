using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public interface IChatParticipant
    {
        void SendMessage(string receiver, string message);
        void ReceiveMessage(string sender, string message);
    }
}
