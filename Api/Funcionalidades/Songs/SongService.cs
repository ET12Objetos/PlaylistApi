using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Songs;

public interface ISongService
{
    void CreateSong(SongDto songDto);
    void DeleteSong(Guid songId);
    List<Song> GetSongs();
    void UpdateSong(Guid songId, SongDto songDto);
}

public class SongService : ISongService
{
    private readonly AplicacionDbContext context;

    public SongService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateSong(SongDto songDto)
    {
        context.Songs.Add(new Song(songDto.Nombre, songDto.Duracion));

        context.SaveChanges();
    }

    public void DeleteSong(Guid songId)
    {
        var song = context.Songs.FirstOrDefault(x => x.Id == songId);

        if (song != null)
        {
            context.Songs.Remove(song);
            context.SaveChanges();
        }
    }

    public List<Song> GetSongs()
    {
        return context.Songs.ToList();
    }

    public void UpdateSong(Guid songId, SongDto songDto)
    {
        var song = context.Songs.FirstOrDefault(x => x.Id == songId);

        if (song != null)
        {
            song.Nombre = songDto.Nombre;
            song.Duracion = songDto.Duracion;
            context.SaveChanges();
        }
    }
}