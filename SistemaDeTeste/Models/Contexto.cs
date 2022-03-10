using Microsoft.EntityFrameworkCore;

namespace SistemaDeTeste.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { 
        
        }
        public DbSet<Funcionarios>Funcionarios { get; set; }
    }
}
