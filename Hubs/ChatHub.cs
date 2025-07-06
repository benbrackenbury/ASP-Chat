using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
  public async Task SendMessage(string message)
  {
    var user = Context.User!.Identity!.Name;
    await Clients.All.SendAsync("ReceiveMessage", user, message);
  }
}
