using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message, string room_id)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message, room_id);
            //Clients.Group(room_id).broadcaseMessage(name, message);
        }

    }
}