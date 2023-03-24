using TaskCollectionApi.Models;
using TaskCollectionApi.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<TaskCollectionDbSettings>(
    builder.Configuration.GetSection("TaskCollectionDb"));  

builder.Services.AddSingleton<TasksService>();