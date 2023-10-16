using Api.Funcionalidades.Songs;
using Api.Persistencia;
using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalidades.Playlists;

public interface IPlaylistService
{
    void AddSongToPlaylist(Guid songId, Guid playlistId);
    void CreateSong(PlaylistCommandDto playlistDto);
    void DeleteSong(Guid playlistId);
    void RemoveSongFromPlaylist(Guid songId, Guid playlistId);
    List<PlaylistQueryDto> GetPlaylists();
    void UpdateSong(Guid playlistId, PlaylistCommandDto playlistDto);
}

public class PlaylistService : IPlaylistService
{
    private readonly AplicacionDbContext context;

    public PlaylistService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void AddSongToPlaylist(Guid songId, Guid playlistId)
    {
        var song = context.Songs.FirstOrDefault(x => x.Id == songId);

        var playlist = context.Playlists.FirstOrDefault(x => x.Id == playlistId);

        if (song != null && playlist != null)
        {
            playlist.AgregarCancion(song);

            context.SaveChanges();
        }
    }

    public void CreateSong(PlaylistCommandDto playlistDto)
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

    public void RemoveSongFromPlaylist(Guid songId, Guid playlistId)
    {
        var song = context.Songs.FirstOrDefault(x => x.Id == songId);

        var playlist = context.Playlists.FirstOrDefault(x => x.Id == playlistId);

        if (song != null && playlist != null)
        {
            playlist.BorrarCancion(song);

            context.SaveChanges();
        }
    }

    public List<PlaylistQueryDto> GetPlaylists()
    {
        return context.Playlists
            .Include(x => x.Songs)
            .Select(x => new PlaylistQueryDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Songs = x.Songs.Select(y => new SongQueryDto { Id = y.Id, Nombre = y.Nombre, Duracion = y.Duracion }).ToList()
            }).ToList();
    }

    public void UpdateSong(Guid playlistId, PlaylistCommandDto playlistDto)
    {
        var playlist = context.Playlists.FirstOrDefault(x => x.Id == playlistId);

        if (playlist != null)
        {
            playlist.Nombre = playlistDto.Nombre;
            context.SaveChanges();
        }
    }
}