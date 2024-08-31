﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDolly.Models.Puppets.DollyPuppet;

public class ColorModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; } 
    
    public string ColorRGB { get; set; }

    public List<ClothesModel> Clothes { get; set; } = new List<ClothesModel>();
}