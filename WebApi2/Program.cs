using Microsoft.EntityFrameworkCore;
using WebApi2.Models;

var builder = WebApplication.CreateBuilder(args);



var connectionString = "Server=(localdb)\\MSSQLLocalDb;Database=WebServer1;Trusted_Connection=True;MultipleActiveResultSets=true";

builder.Services.AddDbContext<ClientContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
