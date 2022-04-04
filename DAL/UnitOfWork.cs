using ProyectoFinal.Entidades;
using ProyectoFinal.IConfiguration;
using ProyectoFinal.Repositories;

namespace ProyectoFinal.DAL;

public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _context;
    public ILogger _logger;
    public GenericRepository<Paciente> Pacientes { get; }
    public AseguradoraRepository Aseguradoras { get; }
    public GenericRepository<Cita> Citas { get; }
    public GenericRepository<Sintoma> Sintomas { get; }

    public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
    {
        _context = context;
        _logger = loggerFactory.CreateLogger("logs");
        Pacientes = new PacienteRepository(context, _logger);
        Aseguradoras = new AseguradoraRepository(context, _logger);
        Citas = new CitaRepository(context, _logger);
        Sintomas = new SintomaRepository(context, _logger);
    }


    public bool Save()
    {
        return _context.SaveChanges() > 0;
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}