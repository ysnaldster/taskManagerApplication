using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerApplication.Entities;

public class Task
{
    [Key]
    public Guid Guid { get; set; }
    
    [ForeignKey("CategoryGuid")]
    public Guid CategoryGuid { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Title { get; set; }
    
    public string Description { get; set; }
    public Priority PriorityTask { get; set; }
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