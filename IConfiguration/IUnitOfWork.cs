using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IBLL;
using ProyectoFinal.BLL;

namespace ProyectoFinal.IConfiguration;

public interface IUnitOfWork : IDisposable
{
    // ApplicationDbContext _context { get; }
    GenericBLL<Paciente> Pacientes { get; }
    AseguradoraBLL Aseguradoras { get; }
    GenericBLL<Cita> Citas { get; }
    GenericBLL<Sintoma> Sintomas { get; }
    // ILogger _logger { get;  }
    
    bool Save();
    void Dispose();
}