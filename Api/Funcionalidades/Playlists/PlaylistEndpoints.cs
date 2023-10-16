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


        app.MapPost("/api/playlist", ([FromServices] IPlaylistService playlistService, PlaylistDto playlistDto) =>
        {
            playlistService.CreateSong(playlistDto);

            return Results.Ok();
        });

        app.MapPut("/api/playlist/{playlistId}", ([FromServices] IPlaylistService playlistService, Guid playlistId, PlaylistDto playlistDto) =>
        {
            playlistService.UpdateSong(playlistId, playlistDto);

            return Results.Ok();
        });

        app.MapDelete("/api/playlist/{playlistId}", ([FromServices] IPlaylistService playlistService, Guid playlistId) =>
        {
            playlistService.DeleteSong(playlistId);

            return Results.Ok();
        });
    }
}