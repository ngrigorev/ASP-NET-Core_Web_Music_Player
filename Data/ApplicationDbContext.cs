using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data;

namespace MusicPlayer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MusicPlaylist>().HasKey(sc => new { sc.MusicId, sc.PlaylistId });
        }

        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<MusicPlaylist> MusicPlaylist { get; set; }
    }
}
