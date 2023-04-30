using Microsoft.AspNetCore.SignalR;

namespace BlazorAppWithSignalR.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task IncrementCountMessage(string message)
        {
            await Clients.All.SendAsync("IncrementCountMessage", message);
        }

    }
}
