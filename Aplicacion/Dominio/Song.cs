namespace Aplicacion.Dominio;
public class Song
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public int Duracion { get; set; }

    public Song(string nombre, int duracion)
    {
        Nombre = nombre;
        Duracion = duracion;
    }
}