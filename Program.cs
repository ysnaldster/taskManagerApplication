using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerApplication.Context;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TaskManagerApplicationContext>(p => 
    //p.UseInMemoryDatabase("taskManagerDb"));
builder.Services.AddNpgsql<TaskManagerApplicationContext>
    (builder.Configuration.GetConnectionString("task_manager_db"));
//builder.Services.AddSqlServer<TaskManagerApplicationContext>("Data Source=X;" +
                                                             //"Initial Catalog=X;user id=sa;password=dominio ");

var app = builder.Build();


app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconnection", async ([FromServices] 
    TaskManagerApplicationContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database in memory: " + dbContext.Database.IsInMemory());
});

app.Run();
