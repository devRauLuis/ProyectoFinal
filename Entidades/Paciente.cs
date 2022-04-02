using System.ComponentModel.DataAnnotations;
using ProyectoFinal.Enums;

namespace ProyectoFinal.Entidades;

public class Paciente
{
    [Key]
    public int PacienteId { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Apellido { get; set; }

    [Required]
    public string Direccion { get; set; }

    [Required]
    [Phone]
    public string Telefono { get; set; }

    [Required]
    public int Edad { get; set; }

    [Required]
    public Sexo Sexo { get; set; }

    [Required]
    public EstadoCivil EstadoCivil { get; set; }

    public int NivelEducativo { get; set; }
    
    [Required]
    public string Cedula { get; set; }
    
    public string Ocupacion { get; set; }
    
    [Required]
    [RegularExpression("/^[0-9]*$/", ErrorMessage = "Solo puede contener numeros")]
    public string NSS { get; set; }

    public Aseguradora Aseguradora { get; set; }
}