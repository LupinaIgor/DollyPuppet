using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDolly.Models.Puppets.DollyPuppet;

public class DollyModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }

    public List<ClothesModel> Clothes { get; set; } = new List<ClothesModel>();
}