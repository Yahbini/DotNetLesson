var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // cấu hình vào wwwroot. đặt dấu ~ vào wwwroot

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");


app.Run();
