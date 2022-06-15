namespace ChatAsIntroToDependencyInversion
{
    internal class ChatClient
    {
        private string _name;
        private ChatServer _server;

        public ChatClient(string name, ChatServer server)
        {
            _server = server;
            _name = name;
            _server.Register(this);
        }

        public void Say(string message)
        {
            _server.Broadcast(this, $"{_name} sier {message}.");
            ;
        }

        public void Recieve(string message)
        {
            Console.WriteLine($"{_name} mottok: {message}");
        }
    }
}
