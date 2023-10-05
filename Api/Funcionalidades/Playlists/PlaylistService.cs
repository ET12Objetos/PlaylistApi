using Aplicacion.Dominio;

namespace Api.Funcionalidades.Playlists;

public interface IPlaylistService
{
    List<Playlist> GetPlaylists();
}

public class PlaylistService : IPlaylistService
{

    List<Playlist> playlists;

    public PlaylistService()
    {
        playlists = new List<Playlist>()
        {
            new Playlist("Rock nacional"),
            new Playlist("Metal")
        };
    }

    public List<Playlist> GetPlaylists()
    {
        return playlists;
    }
}