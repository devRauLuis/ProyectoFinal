using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IBLL;

namespace ProyectoFinal.BLL;

public class CitaBLL : GenericBLL<Cita>, ICitaBLL
{
    public CitaBLL(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}