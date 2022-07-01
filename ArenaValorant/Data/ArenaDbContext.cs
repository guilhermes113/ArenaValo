using ArenaValorant.Models;
using Microsoft.EntityFrameworkCore;

namespace ArenaValorant.Data
{
    public class ArenaDbContext : DbContext
    {
        public ArenaDbContext(DbContextOptions<ArenaDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogadorTime>().HasKey(af => new
            {
                af.JogadorId,
                af.TimeId
            });

            modelBuilder.Entity<PatenteJogador>().HasKey(af => new
            {
                af.PatenteId,
                af.JogadorId
            });
        }

        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<JogadorTime> JogadoresTimes { get; set; }
        public DbSet<Patente> Patentes { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<PatenteJogador> PatentesJogadores { get; set; }
        public DbSet<Treinador> Treinadores { get; set; }
    }
}
