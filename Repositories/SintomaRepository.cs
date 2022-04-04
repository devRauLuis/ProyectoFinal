using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;

namespace ProyectoFinal.Repositories;

public class SintomaRepository : GenericRepository<Sintoma>, ISintomaRepository
{
    public SintomaRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}