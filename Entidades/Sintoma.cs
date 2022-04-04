using System.ComponentModel.DataAnnotations;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.Entidades;

public class Sintoma : ICreatedUpdated
{
    [Key] public int SintomasId { get; set; }

    [Required] public string Descripcion { get; set; }

    public DateTime? CreadoEn { get; set; } = DateTime.Now;

    public DateTime? ActualizadoEn { get; set; } = DateTime.Now;
}