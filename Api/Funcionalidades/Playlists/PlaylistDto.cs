using Api.Funcionalidades.Songs;

namespace Api.Funcionalidades.Playlists;
public class PlaylistCommandDto
{
    public required string Nombre { get; set; }
}

public class PlaylistQueryDto
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; } = string.Empty;

    public List<SongQueryDto> Songs { get; set; } = new List<SongQueryDto>();
}