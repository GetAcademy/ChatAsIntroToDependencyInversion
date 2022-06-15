namespace ChatAsIntroToDependencyInversion
{
    internal class ChatServer
    {
        List<ChatClient> _clients;

        public ChatServer()
        {
            _clients = new List<ChatClient>();
        }

        public void Broadcast(ChatClient client, string message)
        {
            foreach (var chatClient in _clients.Where(chatClient => chatClient != client))
            {
                chatClient.Recieve(message);
            }
        }

        public void Register(ChatClient chatClient)
        {
            _clients.Add(chatClient);
        }
    }
}
