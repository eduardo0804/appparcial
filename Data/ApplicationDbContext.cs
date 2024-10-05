using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace appparcial.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<appparcial.Models.RegistroRemesa> DataRegistroRemesa { get; set; }
    public DbSet<appparcial.Models.HistorialConversion> HistorialConversiones { get; set; }
}
