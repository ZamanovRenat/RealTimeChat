using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly string _botUser;
        public ChatHub()
        {
            _botUser = "MyChat Bot";
        }
        public async Task JoinRoom(UserConnection userConnection)
        {
            await Clients.All.SendAsync("ReceiveMessage", _botUser, 
                $"{userConnection.User} has joined {userConnection.Room}");
        }
    }
}
