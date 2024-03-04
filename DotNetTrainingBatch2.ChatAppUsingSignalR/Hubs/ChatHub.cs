using Microsoft.AspNetCore.SignalR;

namespace DotNetTrainingBatch2.ChatAppUsingSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task ServerReceiveMessage(string user, string message)
        {
            await Clients.All.SendAsync("ClientReceiveMessage", user, message);
        }
    }
}
