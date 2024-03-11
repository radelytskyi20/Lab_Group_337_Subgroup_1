using Library.Constants;
using Library.Data;
using Library.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IClientsManagerService, ClientsManagerService>();
builder.Services.AddTransient<IHoldingsManagerService, HoldingsManagerService>();
builder.Services.AddTransient<IMastersManagerService, MastersManagerService>(); 

builder.Services.AddCors();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite($"Data Source={ConnectionStrings.Default}");
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.MapControllers();

app.Run();
