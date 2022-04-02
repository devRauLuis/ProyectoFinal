using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Entidades;

public class Aseguradora
{
    [Key] public int AseguradoraId { get; set; }

    [Required]
    [MaxLength(40, ErrorMessage = "El tamaño no puede exceder 40 caracteres"),]
    public string Nombre { get; set; }

    [Required] 
    [Phone] 
    public string Telefono { get; set; }

    [Required] 
    [EmailAddress] 
    public string Correo { get; set; }
}