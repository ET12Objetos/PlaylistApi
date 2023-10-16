using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Playlists;

public interface IPlaylistService
{
    List<Playlist> GetPlaylists();
}

public class PlaylistService : IPlaylistService
{
    private readonly AplicacionDbContext context;

    public PlaylistService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public List<Playlist> GetPlaylists()
    {
        return context.Playlists.ToList();
    }
}