using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Songs;

public interface ISongService
{
    void CreateSong(SongCommandDto songDto);
    void DeleteSong(Guid songId);
    List<SongQueryDto> GetSongs();
    void UpdateSong(Guid songId, SongCommandDto songDto);
}

public class SongService : ISongService
{
    private readonly AplicacionDbContext context;

    public SongService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateSong(SongCommandDto songDto)
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

    public List<SongQueryDto> GetSongs()
    {
        return context.Songs.Select(x => new SongQueryDto { Id = x.Id, Nombre = x.Nombre, Duracion = x.Duracion }).ToList();
    }

    public void UpdateSong(Guid songId, SongCommandDto songDto)
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