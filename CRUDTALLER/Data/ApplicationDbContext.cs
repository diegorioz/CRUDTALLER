// Data/ApplicationDbContext.cs


//Recordemos que el EntityFrameworkCore proporciona funcionalidades

// para trabajar con las base de datos en .net

using Microsoft.EntityFrameworkCore;


//Importamos la libreria que contiene los modelos de la aplicación

using CRUDTALLER.Models;


namespace SalesManagementApp.Data

{

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
   
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

      

        //Ejemplo DbSet<Producto> representa la tabla producto en la base de datos

    
        



        //Sobreescribimos ciertas convenciones predeterminadas del entity framework

        //protected override void OnModelCreating(ModelBuilder modelBuilder)

        //{


        //    //LLamar a la implementacion de la clase base para asegurarnos que

        //    //cualquier configuracion realizada alli se aplique

        //    base.OnModelCreating(modelBuilder);

        //    //Podemos configurar la precision de la escala de las propiedades de decimales

            
        //}
        public DbSet<CRUDTALLER.Models.Pelicula> Pelicula { get; set; } = default!;
    }
}