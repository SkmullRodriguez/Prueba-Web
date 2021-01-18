using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Prueba_Web.Models;

namespace Prueba_Web.Data
{
    public class PruebaContext : DbContext
    {
        // creacion del contructor
        public PruebaContext(DbContextOptions<PruebaContext> options) : base(options)
        {
            //
        }

        // *
        public DbSet<tbl_Clientes> Clientes { get; set; }
        public DbSet<tbl_Control_actividades> Control_Actividades { get; set; }
        public DbSet<tbl_Marcaciones> Marcaciones { get; set; }
        public DbSet<tbl_Permisos> Permisos { get; set; }
        public DbSet<tbl_Tipos_usuarios> Tipos_Usuarios { get; set; }
        public DbSet<tbl_Usuarios> Usuarios { get; set; }
    }
}
