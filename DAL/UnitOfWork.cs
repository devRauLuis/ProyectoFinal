using ProyectoFinal.Entidades;
using ProyectoFinal.IConfiguration;
using ProyectoFinal.BLL;

namespace ProyectoFinal.DAL;

public class UnitOfWork : IUnitOfWork
{
    public ApplicationDbContext _context;
    public ILogger _logger;
    public GenericBLL<Paciente> Pacientes { get; }
    public AseguradoraBLL Aseguradoras { get; }
    public GenericBLL<Cita> Citas { get; }
    public GenericBLL<Sintoma> Sintomas { get; }

    public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
    {
        _context = context;
        _logger = loggerFactory.CreateLogger("logs");
        Pacientes = new PacienteBLL(context, _logger);
        Aseguradoras = new AseguradoraBLL(context, _logger);
        Citas = new CitaBLL(context, _logger);
        Sintomas = new SintomaBLL(context, _logger);
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