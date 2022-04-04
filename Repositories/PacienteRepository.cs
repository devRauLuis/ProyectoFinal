using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;

namespace ProyectoFinal.Repositories;

public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
{
    public PacienteRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }
}

// public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
// {
//     public PacienteRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
//     {
//     }
//
//     public override async Task<IEnumerable<Paciente>> All()
//     {
//         try
//         {
//             return await dbSet.ToListAsync();
//         }
//         catch (Exception e)
//         {
//             _logger.LogError(e, "{Repo} All function error", typeof(PacienteRepository));
//             return new List<Paciente>();
//         }
//     }
//
//     public override async Task<bool> Upsert(Paciente paciente)
//     {
//         try
//         {
//             var existingPaciente = await dbSet.FirstOrDefaultAsync(p => p.PacienteId == paciente.PacienteId);
//             if (existingPaciente is null)
//                 return await Add(paciente);
//             existingPaciente.Apellido = paciente.Apellido;
//             existingPaciente.Aseguradora = paciente.Aseguradora;
//             existingPaciente.Cedula = paciente.Cedula;
//             existingPaciente.Direccion = paciente.Direccion;
//             existingPaciente.Edad = paciente.Edad;
//             existingPaciente.Nombre = paciente.Nombre;
//             existingPaciente.Ocupacion = paciente.Ocupacion;
//             existingPaciente.Telefono = paciente.Telefono;
//             existingPaciente.EstadoCivil = paciente.EstadoCivil;
//             existingPaciente.NivelEducativo = paciente.NivelEducativo;
//             return true;
//         }
//         catch (Exception ex)
//         {
//             _logger.LogError(ex, "{Repo} Upsert function error", typeof(PacienteRepository));
//             return false;
//         }
//     }
//
//     public override async Task<bool> Delete(int id)    {
//         try
//         {
//             var exists = await dbSet.FirstOrDefaultAsync(p => p.PacienteId == id);
//             if (exists == null) return false;
//             
//             dbSet.Remove(exists);
//             return true;
//         }
//         catch (Exception e)
//         {
//             _logger.LogError(e, "{Repo} Delete function error", typeof(PacienteRepository));
//             return false;
//         }
//     }
// }