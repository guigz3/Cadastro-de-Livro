using Microsoft.EntityFrameworkCore;
using CadastroLivro.Models;

namespace CadastroLivro.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=CadastroLivroDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}