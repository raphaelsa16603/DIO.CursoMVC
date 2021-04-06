using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models {
    public class Context : DbContext{
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source = CursoAspMVC.db");
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
