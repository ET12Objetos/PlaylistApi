namespace Api.Funcionalidades.Songs;
public class SongCommandDto
{
    public required string Nombre { get; set; }
    public required int Duracion { get; set; }
}

public class SongQueryDto
{
    public Guid Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int Duracion { get; set; }
}