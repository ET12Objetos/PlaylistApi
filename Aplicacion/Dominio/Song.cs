using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Song")]
public class Song
{
    [Key]
    [Required]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    public int Duracion { get; set; }

    public Song(string nombre, int duracion)
    {
        Nombre = nombre;
        Duracion = duracion;
    }
}