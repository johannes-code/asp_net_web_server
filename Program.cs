var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.UseDefaultFiles();

app.MapGet("/", () => "This \n is \n not \n another \n\n hello world");
app.MapGet("/health", () => "Server OK");




app.Run();
