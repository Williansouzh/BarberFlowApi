using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using CrossCutting.IoC;
//using CrossCutting.IoC;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddInfrastructureAPI(builder.Configuration); 
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//builder.Services.AddInfrastructureAPI(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// string? mySqlConnection = builder.Configuration
//                                 .GetConnectionString("DefaultConnection");

// builder.Services.AddDbContext<AppDbContext>(options =>
//                     options.UseMySql(mySqlConnection,
//                     ServerVersion.AutoDetect(mySqlConnection)));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();


