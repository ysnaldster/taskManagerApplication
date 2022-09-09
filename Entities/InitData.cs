namespace TaskManagerApplication.Entities;

public class InitData
{
    public static List<Category> LoadCategories()
    {
        List<Category> categoriesInit = new List<Category>();
        categoriesInit.Add(new Category() 
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea2729e"), 
            Name = "Pending Activities", 
            Description = "", 
            Time = 20
        });
        categoriesInit.Add(new Category() 
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27202"), 
            Name = "Family Activities", 
            Description = "", 
            Time = 30
        });
        categoriesInit.Add(new Category() 
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27219"), 
            Name = "Developer Activities", 
            Description = "", 
            Time = 40
        });
        categoriesInit.Add(new Category()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27222"), 
            Name = "Home Activities", 
            Description = "", 
            Time = 80
        });
        categoriesInit.Add(new Category()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27230"), 
            Name = "Artistic Activities", 
            Description = "", 
            Time = 15
        });
        return categoriesInit;
    }
    
    public static List<Task> LoadTasks()
    {
        List<Task> tasksInit = new List<Task>();
        tasksInit.Add(new Task()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27210"), 
            CategoryID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea2729e"), 
            Author = "Ysnaldo", PriorityTask = Task.Priority.Medium, 
            Title = "Pay Public Services", CreationDate = DateTime.Now
        });
        tasksInit.Add(new Task()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27211"), 
            CategoryID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27202"), 
            Author = "Marta", 
            PriorityTask = Task.Priority.Low, 
            Title = "Finish movie in Netflix", CreationDate = DateTime.Now
        });
        tasksInit.Add(new Task()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27212"), 
            CategoryID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27219"), 
            Author = "Natalia", 
            PriorityTask = Task.Priority.Medium, 
            Title = "Make a Java Project", CreationDate = DateTime.Now
        });
        tasksInit.Add(new Task()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27213"), 
            CategoryID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27222"), 
            Author = "Marco", 
            PriorityTask = Task.Priority.High, 
            Title = "Clear the house", CreationDate = DateTime.Now
        });
        tasksInit.Add(new Task()
        {
            ID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27214"), 
            CategoryID = Guid.Parse("c98f14ab-de8c-4883-819b-95de0ea27230"), 
            Author = "Lucía", 
            PriorityTask = Task.Priority.Low, 
            Title = "Drow a Car", CreationDate = DateTime.Now
        });
        return tasksInit;
    }
}