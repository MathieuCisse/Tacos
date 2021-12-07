using Microsoft.EntityFrameworkCore;
using System;

namespace Tacos
{
    public class TacosContext:DbContext
    {
        public DbSet<Tacos> Tacos { get; set; }
        
        public TacosContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = "server=localhost;port=3306;database=tacos;uid=root;password=;TreatTinyAsBoolean=false";
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Composition>()
                .HasKey(x => new {x.IngredientId, x.TacosId})
                ;

        }
    }
}