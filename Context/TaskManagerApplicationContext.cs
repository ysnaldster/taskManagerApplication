using Microsoft.EntityFrameworkCore;
using TaskManagerApplication.Entities;
using Task = TaskManagerApplication.Entities.Task;

namespace TaskManagerApplication.Context;

public class TaskManagerApplicationContext : DbContext
{
    //Set de datos del modelo creado (Representa una tabla)
    public DbSet <Category> Categories { get; set; }
    public DbSet<Task> Tasks { get; set; }

    public TaskManagerApplicationContext(DbContextOptions<TaskManagerApplicationContext> options) : base(options) {}
    
}