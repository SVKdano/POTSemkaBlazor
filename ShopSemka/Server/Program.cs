global using ShopSemka.Shared;
global using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ResponseCompression;
using ShopSemka.Server.Data;
using ShopSemka.Server.Services.ProductService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//DB 
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//ADD SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//ADD SERVICE
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

//ADD SWAGGER
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//ADD SWAGGER
app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

