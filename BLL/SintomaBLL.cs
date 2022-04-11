using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IBLL;

namespace ProyectoFinal.BLL;

public class SintomaBLL : GenericBLL<Sintoma>, ISintomaBLL
{
    public SintomaBLL(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}