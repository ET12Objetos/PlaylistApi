using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Songs;

public interface ISongService
{
    List<Song> GetSongs();
}

public class SongService : ISongService
{
    private readonly AplicacionDbContext context;

    public SongService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public List<Song> GetSongs()
    {
        return context.Songs.ToList();
    }
}