using webrtc_signal.Hubs;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.UseRouting();
app.MapHub<ChatHub>("/chat");
app.Run();
