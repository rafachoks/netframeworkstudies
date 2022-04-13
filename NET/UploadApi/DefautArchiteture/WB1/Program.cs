using Blinks.Project.Data;
using Blinks.Project.Data.Context;
using Blinks.Project.Data.Repository;
using Blinks.Project.Domain;
using Blinks.Project.Service;
using Blinks.Project.Service.Services;
using Blinks.Project.Service.Validators;
using Microsoft.EntityFrameworkCore;
using WB1.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SqlContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connstring")));

builder.Services.AddScoped<SqlContext, SqlContext>();
builder.Services.AddSingleton<User>();
builder.Services.AddSingleton<Midia>();

builder.Services.AddTransient<IBaseService<User>, UserService>();

builder.Services.AddTransient<IBaseRepository<User>, UserRepository>();

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
