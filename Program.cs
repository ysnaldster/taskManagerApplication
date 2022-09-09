using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerApplication.Context;
using TaskManagerApplication.Entities;
using Task = TaskManagerApplication.Entities.Task;

// Para que se puedan usar los datos de dateTime de la tabla Task
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TaskManagerApplicationContext>(p => 
    //p.UseInMemoryDatabase("taskManagerDb"));
builder.Services.AddNpgsql<TaskManagerApplicationContext>
    (builder.Configuration.GetConnectionString("task_manager_db"));
//builder.Services.AddSqlServer<TaskManagerApplicationContext>(builder.Configuration.GetConnectionString("task_manager_db")));

var app = builder.Build();
app.MapGet("/dbconnection", async ([FromServices] 
    TaskManagerApplicationContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database in memory: " + dbContext.Database.IsInMemory());
});

//GET ENDPOINTS 

//Traer tarea por ID 

app.MapGet("/api/task/{id}", async ([FromServices] TaskManagerApplicationContext dbContext, [FromRoute] Guid id) 
    =>
{
    var currentTask = dbContext.Task.Find(id);
    if (currentTask != null)
    {
        return Results.Ok(dbContext.Task.Include(task => 
            task.Category).Where(e => e.ID == id));
    }

    return Results.NotFound();
});

//Trae todas las tareas en la base de datos 
app.MapGet("/api/task", async ([FromServices] TaskManagerApplicationContext dbContext) 
    => Results.Ok(dbContext.Task));

//Trae las tareas que cumplan con la prioridad baja 
app.MapGet("/api/task/lowPriority", async ([FromServices] TaskManagerApplicationContext dbContext) => {
    return Results.Ok(dbContext.Task.Where(p => p.PriorityTask == Task.Priority.Low));
});

//Trae el cruce completo entre tarea y categoria 
app.MapGet("/api/task/allWithCategory", async ([FromServices] TaskManagerApplicationContext dbContext) => {
    return Results.Ok(dbContext.Task.Include(p => p.Category));
});

//Traer las categorias que tengan un tiempo menor o igual a 30
app.MapGet("/api/task/findCategoriesDownThirty", async ([FromServices] TaskManagerApplicationContext dbContext) => {
    return Results.Ok(dbContext.Task.Include(p => p.Category).Where(e => e.Category.Time <= 40));
});

//POST ENDPOINTS 
app.MapPost("/api/insertTask", async ([FromServices] TaskManagerApplicationContext dbContext, [FromBody] Task task) =>
{
    task.ID = Guid.NewGuid();
    task.CreationDate = DateTime.Now;
    await dbContext.AddAsync(task);
    //Segunda forma de agregar un registro. 
    //await dbContext.Task.AddAsync(task);
    
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

//UPDATE ENDPOINTS
app.MapPut("/api/updateTask/{id}", async ([FromServices] TaskManagerApplicationContext dbContext, [FromBody] Task task,
    [FromRoute] Guid id) =>
{
    var currentTask = dbContext.Task.Find(id);

    if (currentTask != null)
    {
        currentTask.CategoryID = task.CategoryID;
        currentTask.Title = task.Title;
        currentTask.PriorityTask = task.PriorityTask;
        currentTask.Author = task.Author;
        currentTask.Description = task.Description;

        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }

    return Results.NotFound();
});

app.MapPut("/api/updateTaskCategory/{id}", async ([FromServices] TaskManagerApplicationContext dbContext,
    [FromBody] Category category,
    [FromRoute] Guid id) =>
{
    var currentTask = dbContext.Task.Find(id);
    if (currentTask != null)
    {
        currentTask.Category = category;
        await dbContext.SaveChangesAsync();

        return Results.Ok();
    }

    return Results.NotFound();
});

//DELETE ENDPOINTS
app.MapDelete("/api/deleteTask/{id}", async ([FromServices] TaskManagerApplicationContext dbContext, 
    [FromRoute] Guid id) =>
{
    var currentTask = dbContext.Task.Find(id);
    if (currentTask != null)
    {
        dbContext.Remove(currentTask);
        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }
    
    return Results.NotFound();
});

app.Run();
