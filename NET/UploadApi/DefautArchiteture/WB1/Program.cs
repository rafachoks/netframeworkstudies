using Blinks.Project.Application.AutoMapper;
using Blinks.Project.Application.Business;
using Blinks.Project.Application.Interface;
using Blinks.Project.Application.Model;
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
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //For root applications
//builder.Services.AddAutoMapper(typeof(UserProfile)); // For standard applications

builder.Services.AddAutoMapper(typeof(UserProfile));

#endregion

#region Builder Domains
builder.Services.AddSingleton<User>();
builder.Services.AddSingleton<UserModel>();
builder.Services.AddSingleton<Midia>();
#endregion

#region Builder Services Application
builder.Services.AddTransient<IUserBusiness, UserBusiness>();
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
