using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class AddForeignKeyPlaylist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Playlist_PlaylistId",
                table: "Song");

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

            migrationBuilder.RenameColumn(
                name: "PlaylistId",
                table: "Song",
                newName: "IdPlaylist");

            migrationBuilder.RenameIndex(
                name: "IX_Song_PlaylistId",
                table: "Song",
                newName: "IX_Song_IdPlaylist");

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("32ca83ae-f15a-4253-8632-e519de605e1f"), "Playlist 2" },
                    { new Guid("bd84c892-c3c3-4e29-a9d5-26c1dc2ae249"), "Playlist 1" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Duracion", "IdPlaylist", "Nombre" },
                values: new object[,]
                {
                    { new Guid("2d02110e-ff4f-4f0a-a320-7c3b07a0f5ab"), 300, null, "Song 3" },
                    { new Guid("5c48d210-95d0-4475-ab87-d41c0c29edd2"), 200, null, "Song 2" },
                    { new Guid("d25e2e67-c89c-4ace-94fd-4a7c494b3a38"), 100, null, "Song 1" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Playlist_IdPlaylist",
                table: "Song",
                column: "IdPlaylist",
                principalTable: "Playlist",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Playlist_IdPlaylist",
                table: "Song");

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: new Guid("32ca83ae-f15a-4253-8632-e519de605e1f"));

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "Id",
                keyValue: new Guid("bd84c892-c3c3-4e29-a9d5-26c1dc2ae249"));

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: new Guid("2d02110e-ff4f-4f0a-a320-7c3b07a0f5ab"));

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: new Guid("5c48d210-95d0-4475-ab87-d41c0c29edd2"));

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: new Guid("d25e2e67-c89c-4ace-94fd-4a7c494b3a38"));

            migrationBuilder.RenameColumn(
                name: "IdPlaylist",
                table: "Song",
                newName: "PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_Song_IdPlaylist",
                table: "Song",
                newName: "IX_Song_PlaylistId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Playlist_PlaylistId",
                table: "Song",
                column: "PlaylistId",
                principalTable: "Playlist",
                principalColumn: "Id");
        }
    }
}
