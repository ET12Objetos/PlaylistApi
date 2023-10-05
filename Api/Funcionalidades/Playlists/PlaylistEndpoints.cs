using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Playlists;
public class PlaylistEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/playlist", ([FromServices] IPlaylistService playlistService) =>
        {
            return Results.Ok(playlistService.GetPlaylists());
        });
    }
}