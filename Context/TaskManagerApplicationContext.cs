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
    
    //Creación de la base de datos con FluentAPI 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(p => p.ID);
            category.Property(p => p.Name).IsRequired().HasMaxLength(60).HasColumnName("name");
            category.Property(p => p.Description).HasColumnName("description").IsRequired(false);
            category.Property(p => p.Time).HasColumnName("time");

            category.HasData(InitData.LoadCategories());
        });

        modelBuilder.Entity<Task>(task =>
        {
            task.ToTable("Task");
            task.HasKey(p => p.ID);
            task.HasOne(p => p.Category).WithMany(p => p.Tasks);
            task.Property(p => p.Title).IsRequired().HasMaxLength(200).HasColumnName("title");
            task.Property(p => p.Description).HasColumnName("description").IsRequired(false);
            task.Property(p => p.PriorityTask).HasColumnName("priority");
            task.Property(p => p.CreationDate).HasDefaultValue(DateTime.Now).HasColumnName("creation_date");
            task.Property(p => p.Author).HasColumnName("author");
            task.Ignore(p => p.Resumen);

            task.HasData(InitData.LoadTasks());
        });
    }
}