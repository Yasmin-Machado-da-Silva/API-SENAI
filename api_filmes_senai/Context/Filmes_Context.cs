using api_filmes_senai.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace api_filmes_senai.Context
{
    public class Filmes_Context : DbContext
    {
        public Filmes_Context()
        {
            
        }
        public Filmes_Context(DbContextOptions<Filmes_Context>options): base(options) 
        { 
        }   
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filmes> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured) {
                OptionsBuilder.UseSqlServer("Server=Yasmin; Database=Filmes; Integrated Security=True; TrustServerCertificate=true; ");
              }
        }

    }
}
