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
    }
}