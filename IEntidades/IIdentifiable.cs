using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.IEntidades;

public interface IIdentifiable
{
    [Key] public int? Id { get; set; }
}