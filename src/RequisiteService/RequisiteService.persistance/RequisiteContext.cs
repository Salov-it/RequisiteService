using Microsoft.EntityFrameworkCore;
using RequisiteService.Application.Interface;
using RequisiteService.Domain;

namespace RequisiteService.persistance
{
    public class RequisiteContext : DbContext, IRequisiteContext
    {
        public DbSet<Requisite> requisite { get; set; }

        public RequisiteContext(DbContextOptions<RequisiteContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=RequisiteBasse.db");
        }
    }
}
