using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerApplication.Entities;

public class Category
{
    //Indica la PK
    //[Key]
    public Guid ID { get; set; }
    //Required indica que la propiedad es requerida
    //[Required]
    //[MaxLength(60)]
    //[Column("name", TypeName="varchar(60)")]
    public string Name { get; set; }
    
    //[Column("description", TypeName="text")]
    public string Description { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
}
