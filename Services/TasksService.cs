//using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Options;
using MongoDB.Driver;
using TaskCollectionApi.Models;
 
 

namespace TaskCollectionApi.Services;

public class TasksService
{ 
    private readonly IMongoCollection<TaskModel> _tasksCollection;

    public TasksService(
        IOptions<TaskCollectionDbSettings> taskCollectionDbSettings)
    {
        var mongoClient = new MongoClient(
            taskCollectionDbSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            taskCollectionDbSettings.Value.DatabaseName);

        _tasksCollection = mongoDatabase.GetCollection<TaskModel>(
            taskCollectionDbSettings.Value.TasksCollectionName);
    }

    public async Task<List<TaskModel>> GetAsync() =>
        await _tasksCollection.Find(_ => true).ToListAsync();

    public async Task<TaskModel?> GetAsync(string id) =>
        await _tasksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(TaskModel newTask) =>
        await _tasksCollection.InsertOneAsync(newTask);

    public async Task UpdateAsync(string id, TaskModel updatedTask) =>
        await _tasksCollection.ReplaceOneAsync(x => x.Id == id, updatedTask);

    public async Task RemoveAsync(string id) =>
        await _tasksCollection.DeleteOneAsync(x => x.Id == id);
}