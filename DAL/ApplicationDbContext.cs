using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Paciente> Pacientes { get; set; }

    public DbSet<Aseguradora> Aseguradoras { get; set; }

    public DbSet<Sintoma> Sintomas { get; set; }

    public DbSet<Cita> Citas { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Sintoma>().HasData(new Sintoma(){});
    }
    
    
}