using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PC1_Programacion.Data
{
    public class DatabaseContext : DbContext
    {
         public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
          {
          }
     public DbSet<PC1_Programacion.Models.Formulario> Formularios { get; set; }
    }
}