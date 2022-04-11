using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IBLL;

namespace ProyectoFinal.BLL;

public class AseguradoraBLL : GenericBLL<Aseguradora>, IAseguradoraBll
{
    public AseguradoraBLL(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}