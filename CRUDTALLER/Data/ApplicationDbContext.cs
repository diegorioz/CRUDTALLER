// Data/ApplicationDbContext.cs


//Recordemos que el EntityFrameworkCore proporciona funcionalidades

// para trabajar con las base de datos en .net

using Microsoft.EntityFrameworkCore;


//Importamos la libreria que contiene los modelos de la aplicación

using SalesManagementApp.Models;
using CRUDTALLER.Models;


namespace SalesManagementApp.Data

{

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using SalesManagementApp.Models;
    using CRUDTALLER.Models;
    public class ApplicationDbContext : IdentityDbContext

    {

        //ApplicationDbContext permite la inyeccion dependencias y la configuracion

        // de la base de datos

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

        : base(options)
        {

        }

        //Definimos una propiedad dbSet que representa una colección de todas las entidad

        // de un tipo de dato que se almacenaran en la base de datos

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }

        public DbSet<Producto> Producto { get; set; }

        //Ejemplo DbSet<Producto> representa la tabla producto en la base de datos

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Venta> Venta { get; set; }

        public DbSet<DetalleVenta> Detalle { get; set; }

        



        //Sobreescribimos ciertas convenciones predeterminadas del entity framework

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {


            //LLamar a la implementacion de la clase base para asegurarnos que

            //cualquier configuracion realizada alli se aplique

            base.OnModelCreating(modelBuilder);

            //Podemos configurar la precision de la escala de las propiedades de decimales

            modelBuilder.Entity<Producto>()

            .Property(d => d.Precio)

            .HasColumnType("decimal(18,2)");


            modelBuilder.Entity<Venta>()

            .Property(d => d.Total)

            .HasColumnType("decimal(18,2)");


            modelBuilder.Entity<DetalleVenta>()

            .Property(d => d.Subtotal)

            .HasColumnType("decimal(18,2)");
        }
        public DbSet<CRUDTALLER.Models.Pelicula> Pelicula { get; set; } = default!;
    }
}