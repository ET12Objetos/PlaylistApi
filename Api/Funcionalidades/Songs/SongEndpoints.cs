using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Songs;
public class SongEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/song", ([FromServices] ISongService songService) =>
        {
            return Results.Ok(songService.GetSongs());
        });

        app.MapPost("/api/song", ([FromServices] ISongService songService, SongDto songDto) =>
        {
            songService.CreateSong(songDto);

            return Results.Ok();
        });

        app.MapPut("/api/song/{songId}", ([FromServices] ISongService songService, Guid songId, SongDto songDto) =>
        {
            songService.UpdateSong(songId, songDto);

            return Results.Ok();
        });

        app.MapDelete("/api/song/{songId}", ([FromServices] ISongService songService, Guid songId) =>
        {
            songService.DeleteSong(songId);

            return Results.Ok();
        });
    }
}