using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Playlists;

public interface IPlaylistService
{
    void CreateSong(PlaylistDto playlistDto);
    void DeleteSong(Guid playlistId);
    List<Playlist> GetPlaylists();
    void UpdateSong(Guid playlistId, PlaylistDto playlistDto);
}

public class PlaylistService : IPlaylistService
{
    private readonly AplicacionDbContext context;

    public PlaylistService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateSong(PlaylistDto playlistDto)
    {
        context.Playlists.Add(new Playlist(playlistDto.Nombre));

        context.SaveChanges();
    }

    public void DeleteSong(Guid playlistId)
    {
        var playlist = context.Playlists.FirstOrDefault(x => x.Id == playlistId);

        if (playlist != null)
        {
            context.Playlists.Remove(playlist);
            context.SaveChanges();
        }
    }

    public List<Playlist> GetPlaylists()
    {
        return context.Playlists.ToList();
    }

    public void UpdateSong(Guid playlistId, PlaylistDto playlistDto)
    {
        var playlist = context.Playlists.FirstOrDefault(x => x.Id == playlistId);

        if (playlist != null)
        {
            playlist.Nombre = playlistDto.Nombre;
            context.SaveChanges();
        }
    }
}