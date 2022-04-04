using ProyectoFinal.DAL;
using ProyectoFinal.Data;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;
using ProyectoFinal.Repositories;

namespace ProyectoFinal.IConfiguration;

public interface IUnitOfWork : IDisposable
{
    // ApplicationDbContext _context { get; }
    GenericRepository<Paciente> Pacientes { get; }
    AseguradoraRepository Aseguradoras { get; }
    GenericRepository<Cita> Citas { get; }
    GenericRepository<Sintoma> Sintomas { get; }
    // ILogger _logger { get;  }
    
    bool Save();
    void Dispose();
}