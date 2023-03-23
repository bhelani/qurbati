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

builder.Services.Configure<UserCollectionDbSettings>(
    builder.Configuration.GetSection("UserCollectionDb"));  

builder.Services.AddSingleton<TasksService>();  


    
//app.Run();

//.......................................................................................

//string connectionString = "";

/*app.MapGet("/todoitems", async (TodoDb db) =>
    await db.Todos.ToListAsync());

app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
    await db.Todos.FindAsync(id) 
    is Todo todo
        ? Results.Ok(todo)
        : Results.NotFound()
);

app.MapGet("/todoitems/notDone", async (TodoDb db) =>
    await db.Todos.Where(t => t.IsComplete).ToListAsync()
);

app.MapPost("/todoitems", async (Todo todo, TodoDb db) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();

    return Results.Created($"/todoitems/{todo.Id}", todo);
});

app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
{
    var todo = await db.Todos.FindAsync(id);

    if (todo is null) return Results.NotFound();

    todo.Name = inputTodo.Name;
    todo.IsComplete = inputTodo.IsComplete;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/todoitems/{id}", async (int id, TodoDb db) =>
{
    if (await db.Todos.FindAsync(id) is Todo todo)
    {
        db.Todos.Remove(todo);
        await db.SaveChangesAsync();
        return Results.Ok(todo);
    }

    return Results.NotFound();
});
app.MapGet("/", () => "Hello World!");

app.MapGet("/who", () => "bilals web app!");*/


