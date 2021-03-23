﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Lacteos.ProductosBL;

namespace BL.Lacteos
{
    public class Contexto : DbContext
    {
       

        public Contexto() : base("VentasLacteos")

        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio a la base de datos despues de eliminarla
        }


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet <Factura> Facturas { get; set; }
      


    }
}
