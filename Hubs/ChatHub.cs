using Microsoft.AspNetCore.SignalR;

namespace webrtc_signal.Hubs;

public class ChatHub : Hub {

    public async Task SendMessage(string name, string message) {
        await Clients.All.SendAsync("ReceiveMessage", name, message);
    }
    
}