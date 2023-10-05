namespace Aplicacion.Dominio;
public class Playlist
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public List<Song> Songs { get; set; } = new List<Song>();

    public Playlist(string nombre)
    {
        Nombre = nombre;
    }
}