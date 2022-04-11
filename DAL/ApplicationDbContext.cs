using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.DAL;

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

        modelBuilder.Entity<Paciente>().Navigation(p => p.Aseguradora).AutoInclude();
        modelBuilder.Entity<Sintoma>().HasData(new Sintoma()
        {
            Id = 1,
            Descripcion = "Dolor de cabeza"
        });

        modelBuilder.Entity<Sintoma>().HasData(new Sintoma()
        {
            Id = 2,
            Descripcion = "Tos"
        });

        modelBuilder.Entity<Sintoma>().HasData(new Sintoma()
        {
            Id = 3,
            Descripcion = "Vómitos"
        });

        modelBuilder.Entity<Sintoma>().HasData(new Sintoma()
        {
            Id = 4,
            Descripcion = "Dolor de muelas"
        });

        modelBuilder.Entity<Sintoma>().HasData(new Sintoma()
        {
            Id = 5,
            Descripcion = "Caries"
        });

        // 3,ARS Humano,8090000000,contacto@humano.com,2022-04-10 16:12:27.339957,2022-04-10 16:12:27.339816
        // 4,ARS Futuro,8090000000,contacto@futuroars.com,2022-04-10 16:13:39.387344,2022-04-10 16:12:59.953459
        // 5,ARS Monumental,8090000000,contacto@arsmonumental.com,2022-04-10 16:14:15.911803,2022-04-10 16:14:13.361284
    }
}