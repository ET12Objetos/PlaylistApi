using Aplicacion.Dominio;

namespace Api.Funcionalidades.Songs;

public interface ISongService
{
    List<Song> GetSongs();
}

public class SongService : ISongService
{
    List<Song> songs;

    public SongService()
    {
        songs = new List<Song>()
        {
            new Song("Titulo 1", 300),
            new Song("Titulo 2", 250),
            new Song("Titulo 3", 200)
        };
    }

    public List<Song> GetSongs()
    {
        return songs;
    }
}