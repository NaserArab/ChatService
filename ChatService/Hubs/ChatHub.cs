using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatService.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string userName,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", userName, message);
        }
    }
}
