using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerApplication.Entities;

public class Task
{
    [Key]
    public Guid ID { get; set; }
    
    [ForeignKey("CategoryID")]
    [Column("category_id_fk")]
    public Guid CategoryID { get; set; }
    
    [Required]
    [MaxLength(200)]
    [Column("title", TypeName="varchar(200)")]
    public string Title { get; set; }
    
    [Column("description", TypeName="text")]
    public string Description { get; set; }
    
    [Column("priority", TypeName="integer")]
    public Priority PriorityTask { get; set; }
    
    [Column("creation_date")]
    public DateTime CreationDate { get; set; }

    public virtual Category Category { get; set; }
    
    //Propiedad que se va a omitir (No se creara en la base de datos)
    //Esta propiedad indica un resumen de description cuando este sobrepasa
    // la cantidad de caracteres. 
    [NotMapped]
    public string Resumen { get; set; }
    
    public enum Priority
    {
        Low, Medium, High
    }
}