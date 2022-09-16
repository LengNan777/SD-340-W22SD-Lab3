using SD_340_W22SD_Lab3.Models;
using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Lab3.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.Initialize(services);
}

app.Run();