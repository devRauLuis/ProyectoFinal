using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Entidades;

public class Sintoma
{
    [Key]
    public int SintomasId { get; set; }

    [Required]
    public string Descripcion { get; set; }

    [Required]
    public int Veces { get; set; }

    
}