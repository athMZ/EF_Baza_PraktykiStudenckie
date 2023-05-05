using Microsoft.EntityFrameworkCore;

namespace EF_Baza_PraktykiStudenckie.Models
{

    public class PraktykiContext : DbContext
    {
        public PraktykiContext() : base()
        {
        }

        public PraktykiContext(DbContextOptions<PraktykiContext> options) : base(options)
        {
        }

        public DbSet<Firma> Firmy { get; set; }
        public DbSet<Adres> Adresy { get; set; }
        public DbSet<Student> Studenci { get; set; }
        public DbSet<Opiekun> Opiekunowie { get; set; }
        public DbSet<Opiekun_Uczelnia> OpiekunowieUczelnia { get; set; }
        public DbSet<Opiekun_ZakładPracy> OpiekunowieZakładPracy { get; set; }
        public DbSet<Praktyka> Praktyki { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LenovoE14-MZ;Initial Catalog=EF-Praktyki;Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}