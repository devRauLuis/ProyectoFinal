using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;

namespace ProyectoFinal.Repositories;

public class AseguradoraRepository : GenericRepository<Aseguradora>, IAseguradoraRepository
{
    public AseguradoraRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}