using System.ComponentModel.DataAnnotations;

public class Estudiante
{
    [Required(ErrorMessage = "El nombre no debe ser vacío")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El correo no debe ser vacío")]
    [EmailAddress(ErrorMessage = "Correo no válido")]
    public string Correo { get; set; }

    [Range(0, 10, ErrorMessage = "La calificación debe estar entre 0 y 10")]
    public double Calificacion { get; set; }
}