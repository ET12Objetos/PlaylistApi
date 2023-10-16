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


        app.MapPost("/api/playlist", ([FromServices] IPlaylistService playlistService, PlaylistCommandDto playlistDto) =>
        {
            playlistService.CreateSong(playlistDto);

            return Results.Ok();
        });

        app.MapPut("/api/playlist/{playlistId}", ([FromServices] IPlaylistService playlistService, Guid playlistId, PlaylistCommandDto playlistDto) =>
        {
            playlistService.UpdateSong(playlistId, playlistDto);

            return Results.Ok();
        });

        app.MapDelete("/api/playlist/{playlistId}", ([FromServices] IPlaylistService playlistService, Guid playlistId) =>
        {
            playlistService.DeleteSong(playlistId);

            return Results.Ok();
        });

        app.MapPost("/api/playlist/{playlistId}/song/{songId}", ([FromServices] IPlaylistService playlistService, Guid playlistId, Guid songId) =>
        {
            playlistService.AddSongToPlaylist(songId, playlistId);

            return Results.Ok();
        });

        app.MapDelete("/api/playlist/{playlistId}/song/{songId}", ([FromServices] IPlaylistService playlistService, Guid playlistId, Guid songId) =>
        {
            playlistService.RemoveSongFromPlaylist(songId, playlistId);

            return Results.Ok();
        });
    }
}