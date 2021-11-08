using System;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ChatHub:Hub
    {
        public async Task Send()
        {
            
            await Clients.Others.SendAsync("Bro", $"{Context.User.Identity.Name}");
        }
        public async Task SendSis()
        {
            await Clients.Others.SendAsync("Sis", $"{Context.User.Identity.Name}");
        }
    }
}
