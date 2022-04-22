using Blinks.Project.Application.AutoMapper;
using Blinks.Project.Application.Business;
using Blinks.Project.Application.Interface;
using Blinks.Project.Application.Model;
using Blinks.Project.Data;
using Blinks.Project.Data.Context;
using Blinks.Project.Data.Contracts;
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

builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "DevOps Template Blinks",
        Description = "Project template for all future projects",
    });

    #region security for real project
    //var security = new Dictionary<string, IEnumerable<string>>
    //{
    //    {"Bearer", new string[] { }},
    //};

    //opt.AddSecurityDefinition(
    //    "Bearer",
    //    new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    //    {
    //        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
    //        Description = "Copie 'Bearer ' + token'",
    //        Name = "Authorization",
    //        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
    //    });
    #endregion

});

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
builder.Services.AddTransient<IUserRepository, UserRepository>();
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
