using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDolly.Models.Puppets.DollyPuppet;

public class ClothesModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string ImageUrl { get; set; }
    
    public int DollyId { get; set; }
    
    [ForeignKey("DollyId")]
    public DollyModel Dolly { get; set; }
    
    public int ColorId { get; set; }
    
    [ForeignKey("ColorId")]
    public ColorModel Color { get; set; }
    
    public int StyleId { get; set; }
    
    [ForeignKey("StyleId")]
    public StyleModel Style { get; set; }
}