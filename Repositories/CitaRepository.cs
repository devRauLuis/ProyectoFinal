using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;

namespace ProyectoFinal.Repositories;

public class CitaRepository : GenericRepository<Cita>, ICitaRepository
{
    public CitaRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}