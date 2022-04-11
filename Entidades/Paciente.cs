using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Enums;
using ProyectoFinal.IEntidades;
using ServiceStack;

namespace ProyectoFinal.Entidades;

public class Paciente : ICreatedUpdated, IIdentifiable
{
    [Key] public int? Id { get; set; }

    [Required]
    [MinLength(1, ErrorMessage = "Debe tener al menos {1} caracteres")]
    [MaxLength(50, ErrorMessage = "No puede exceder {1} caracteres")]
    public string Nombre { get; set; }

    [Required]
    [MinLength(1, ErrorMessage = "Debe tener al menos {1} caracteres")]
    [MaxLength(50, ErrorMessage = "No puede exceder {1} caracteres")]
    public string Apellido { get; set; }


    [Required]
    [MinLength(5, ErrorMessage = "Debe tener al menos {1} caracteres")]
    [MaxLength(100, ErrorMessage = "No puede exceder {1} caracteres")]
    public string Direccion { get; set; }

    [Required] [Phone] public string Telefono { get; set; }

    [Required]
    [Range(1, 110, ErrorMessage = "Debe ser mayor a {0} y menor a {1}")]
    public int Edad { get; set; }

    [Required] public Sexo Sexo { get; set; }

    [Required] public EstadoCivil EstadoCivil { get; set; }

    public NivelEducativo NivelEducativo { get; set; }

    [Required]
    [RegularExpression("([0-9]+)", ErrorMessage = "Solo puede contener numeros")]
    public string Cedula { get; set; }

    [MinLength(5, ErrorMessage = "Debe tener al menos {1} caracteres")]
    [MaxLength(50, ErrorMessage = "No puede exceder {1} caracteres")]
    public string? Ocupacion { get; set; }

    [Required] public Aseguradora Aseguradora { get; set; }

    public DateTime? CreadoEn { get; set; } = DateTime.Now;
    public DateTime? ActualizadoEn { get; set; } = DateTime.Now;

    public string? NombreCompleto => Nombre + " " + Apellido;
}