using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Playlist")]
public class Playlist
{
    [Key]
    [Required]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string Nombre { get; set; } = string.Empty;

    public List<Song> Songs { get; set; } = new List<Song>();

    public Playlist(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarCancion(Song song) => Songs.Add(song);

    public void BorrarCancion(Song song) => Songs.Remove(song);
}