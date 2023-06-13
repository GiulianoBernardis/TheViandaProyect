using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Filename=TheViandas.db";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(connectionString);
            }
        }

        public DbSet<DetalleReceta> DetallesReceta { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<MateriaPrima> MateriaPrimas { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Vianda> Viandas { get; set; }
    }
}
