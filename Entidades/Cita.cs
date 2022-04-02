namespace ProyectoFinal.Entidades;

public class Cita
{
    public int CitaId { get; set; }

    public DateTime Fecha { get; set; }

    public ICollection<Sintoma> Sintomas { get; set; }

    public Paciente Paciente { get; set; }
}