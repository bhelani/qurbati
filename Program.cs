using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using User;
using Group;
using UserCollectionApi.Models;
using TaskCollectionApi.Services; 
 
/*var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));

var app = builder.Build();*/

var builder = WebApplication.CreateBuilder(args);

var app=builder.Build();

builder.Services.Configure<UserCollectionDbSettings>(
    builder.Configuration.GetSection("UserCollectionDb"));  

builder.Services.AddSingleton<TasksService>(); 

app.Run();
