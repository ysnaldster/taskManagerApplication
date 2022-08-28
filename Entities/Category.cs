using System.ComponentModel.DataAnnotations;

namespace TaskManagerApplication.Entities;

public class Category
{
    //Indica la PK
    [Key]
    public Guid Guid { get; set; }
    //Required indica que la propiedad es requerida
    [Required]
    [MaxLength(60)]
    public string Name { get; set; }
    
    public string Description { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
}
