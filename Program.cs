using TaskCollectionApi.Models;
using TaskCollectionApi.Services;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<TaskCollectionDbSettings>(
    builder.Configuration.GetSection("TaskCollectionDb"));  

builder.Services.AddSingleton<TasksService>();
// start
// string connectionString = "mongodb+srv://bhelani13:ZVfz95LsO6VTyGmj@cluster0.bx1jz4e.mongodb.net/?retryWrites=true&w=majority";
// string databaseName = "Qurbati";
// string collectionName = "Tasks";

// var client = new MongoClient(connectionString);
// var db = client.GetDatabase(databaseName);
// var collection = db.GetCollection<TaskModel>(collectionName);

// var task = new TaskModel {Title = "first task"};

// await collection.InsertOneAsync(task);

// var results = await collection.FindAsync(_ => true);

// foreach (var result in results.ToList()){
//     Console.WriteLine($"{result.Id}: {result.Title}");
// }

//end

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();