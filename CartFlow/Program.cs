using CartFlow.Context;
using CartFlow.Handlers;
using CartFlow.Options;
using CartFlow.Repositories;
using CartFlow.Services;
using CartFlow.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("Jwt"));

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

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddExceptionHandler<ExceptionHandler>().AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header
    });
    
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            []
        }
    });
});
var app = builder.Build();

app.MapControllers();

app.UseExceptionHandler();
app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();