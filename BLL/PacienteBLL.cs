using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IBLL;

namespace ProyectoFinal.BLL;

public class PacienteBLL : GenericBLL<Paciente>, IPacienteBLL
{
    public PacienteBLL(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}
