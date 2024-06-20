using Lesson1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

// Khai báo Service
builder.Services.AddScoped<DemoService, DemoServiceImpl>();
builder.Services.AddScoped<CalculateService, CalculateServiceImpl>();
builder.Services.AddScoped<RectangleService, RectangleServiceImplcs>();
builder.Services.AddScoped<ProductService, ProductServiceImpl>();
builder.Services.AddScoped<AccountService, AccountServiceImpl>();
builder.Services.AddScoped<CertService, CertServiceImpl>();
builder.Services.AddScoped<LanguageService, LanguageServiceImpl>();
builder.Services.AddScoped<RoleService, RoleServiceImpl>();
builder.Services.AddScoped<CartService, CartServiceImpl>();


var app = builder.Build();

app.UseStaticFiles(); // cấu hình vào wwwroot. đặt dấu ~ vào wwwroot
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");


app.Run();
