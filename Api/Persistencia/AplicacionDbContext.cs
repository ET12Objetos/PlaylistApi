using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistencia;
public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> opciones)
        : base(opciones)
    {
    }

    public DbSet<Song> Songs { get; set; }
    public DbSet<Playlist> Playlists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Song>().HasData(
            new Song("Song 1", 100),
            new Song("Song 2", 200),
            new Song("Song 3", 300)
        );

        modelBuilder.Entity<Playlist>().HasData(
            new Playlist("Playlist 1"),
            new Playlist("Playlist 2")
        );
    }
}