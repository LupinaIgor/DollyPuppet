using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationDolly.Models.Puppets.DollyPuppet;

namespace WebApplicationDolly.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<DollyModel> Dolly { get; set; }
    
    public DbSet<ClothesModel> Clothes { get; set; }
    
    public DbSet<ColorModel> Colors { get; set; }
    
    public DbSet<StyleModel> Styles { get; set; }
    
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}