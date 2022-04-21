using Blinks.Project.Application.AutoMapper;
using Blinks.Project.Data;
using Blinks.Project.Data.Context;
using Blinks.Project.Data.Repository;
using Blinks.Project.Domain;
using Blinks.Project.Service;
using Blinks.Project.Service.Services;
using Microsoft.EntityFrameworkCore;

#region You don't have mana to change this :) 
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connstring")));
builder.Services.AddScoped<SqlContext, SqlContext>();

#endregion

#region AutoMapper Profiles
builder.Services.AddAutoMapper(typeof(UserProfile));
#endregion

#region Builder Domains
builder.Services.AddSingleton<User>();
builder.Services.AddSingleton<Midia>();
#endregion

#region Builder Services
builder.Services.AddTransient<IBaseService<User>, UserService>();
#endregion

#region Standard Configuration
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

#endregion
