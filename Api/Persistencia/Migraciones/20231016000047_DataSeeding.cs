using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("16248298-70ba-4ee4-8959-f903c927c31a"), "Playlist 1" },
                    { new Guid("d4eeba3d-2432-44a1-9a12-61112142dd57"), "Playlist 2" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Duracion", "Nombre", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("9a987689-8898-4b1c-85ca-eca50a3a21e4"), 200, "Song 2", null },
                    { new Guid("cd9576d4-c098-4f19-8b97-f6a55a6ecb6e"), 300, "Song 3", null },
                    { new Guid("fb623cf7-e4bb-4088-b1e7-f560cddf72a4"), 100, "Song 1", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: new Guid("16248298-70ba-4ee4-8959-f903c927c31a"));

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: new Guid("d4eeba3d-2432-44a1-9a12-61112142dd57"));

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: new Guid("9a987689-8898-4b1c-85ca-eca50a3a21e4"));

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: new Guid("cd9576d4-c098-4f19-8b97-f6a55a6ecb6e"));

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: new Guid("fb623cf7-e4bb-4088-b1e7-f560cddf72a4"));
        }
    }
}
