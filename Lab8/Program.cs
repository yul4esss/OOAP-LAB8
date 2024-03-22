namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ChatMediator();

            // Creating chat users
            var user1 = new ChatUser("Yuliia", mediator);
            var user2 = new ChatUser("Viktoriia", mediator);
            var user3 = new ChatUser("Veronika", mediator);

            mediator.AddParticipant(user1);
            mediator.AddParticipant(user2);
            mediator.AddParticipant(user3);

            // Using methods to send messages using Mediator
            user1.SendMessage("Viktoriia", "Hey darling!");
            user2.SendMessage("Veronika", "Hi! How're you doing?");
            user3.SendMessage("Viktoriia", "Hello sweetheart! How're you?");

        }
    }
}
