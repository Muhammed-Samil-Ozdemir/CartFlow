using CartFlow.Context;
using CartFlow.Repositories;
using CartFlow.Services;
using CartFlow.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddScoped<CartItemService>();
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<CouponService>();
builder.Services.AddScoped<DiscountService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<CartItemRepository>();
builder.Services.AddScoped<CartRepository>();
builder.Services.AddScoped<CouponRepository>();
builder.Services.AddScoped<DiscountRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<UserRepository>();

builder.Services.AddScoped<UnitOfWork>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();