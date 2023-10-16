using Api.Funcionalidades.Playlists;
using Api.Funcionalidades.Songs;

namespace Api.Funcionalidades;
public static class ServiceManager
{
    public static IServiceCollection AddServiceManager(this IServiceCollection services)
    {
        services.AddScoped<ISongService, SongService>();
        services.AddScoped<IPlaylistService, PlaylistService>();

        return services;
    }
}