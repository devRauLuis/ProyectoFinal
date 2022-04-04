using System.ComponentModel.DataAnnotations;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.Entidades;

public class Aseguradora : ICreatedUpdated
{
    [Key] public int AseguradoraId { get; set; }

    [Required]
    [MaxLength(40, ErrorMessage = "El tamaño no puede exceder 40 caracteres"),]
    public string Nombre { get; set; }

    [Required] [Phone] public string Telefono { get; set; }

    [Required] [EmailAddress] public string Correo { get; set; }

    public DateTime? CreadoEn { get; set; } = DateTime.Now;

    public DateTime? ActualizadoEn { get; set; } = DateTime.Now;
}