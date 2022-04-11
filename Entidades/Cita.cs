using System.ComponentModel.DataAnnotations;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.Entidades;

public class Cita : ICreatedUpdated, IIdentifiable
{
    [Key] public int? Id { get; set; }

    [Required] public DateTime? Inicio { get; set; }

    [Required] public DateTime? Fin { get; set; }

    [Required]
    [MinLength(5, ErrorMessage = "Debe tener al menos {1} caracteres")]
    [MaxLength(50, ErrorMessage = "No puede exceder {1} caracteres")]
    public string? Motivo { get; set; }

    [Required] public ICollection<Sintoma?>? Sintomas { get; set; } = new List<Sintoma?>();

    [Required] public Paciente? Paciente { get; set; }

    public DateTime? CreadoEn { get; set; } = DateTime.Now;
    public DateTime? ActualizadoEn { get; set; } = DateTime.Now;

    // public string? NombreCompleto => Paciente?.Nombre + " " + Paciente?.Apellido;
}