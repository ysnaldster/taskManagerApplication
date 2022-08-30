using Microsoft.EntityFrameworkCore;
using TaskManagerApplication.Entities;
using Task = TaskManagerApplication.Entities.Task;

namespace TaskManagerApplication.Context;

public class TaskManagerApplicationContext : DbContext
{
    //Set de datos del modelo creado (Representa una tabla)
    public DbSet <Category> Category { get; set; }
    public DbSet<Task> Task { get; set; }

    public TaskManagerApplicationContext(DbContextOptions<TaskManagerApplicationContext> options) : base(options) {}
    
}