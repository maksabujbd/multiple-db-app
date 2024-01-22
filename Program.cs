using Microsoft.EntityFrameworkCore;
using MultipleDbApp.Data;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Db Connection
builder.Services.AddDbContext<PrimaryAppDbContext>(option =>
{
    option.UseSqlite(config.GetConnectionString("PrimaryDbConnection"));
});

builder.Services.AddDbContext<SecondaryAppDbContext>(option =>
{
    option.UseSqlite(config.GetConnectionString("SecondaryDbConnection"));
});

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
