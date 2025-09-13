using CRUDTALLER.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SalesManagementApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar la cadena de conexi�n desde appsettings.json

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrar el contexto de datos con el contenedor de dependencias

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();

// Agregar controladores con vistas (MVC)

builder.Services.AddControllersWithViews();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    // Verifica si la tabla Peliculas está vacía
    if (!context.Peliculas.Any())
    {
        return;
    }
//    context.Peliculas.AddRange(
//        new Pelicula
//        {
//            Titulo = "El conjuro",
//            Descripcion = "Película de terror",
//            Categoria = "Terror",
//            ImagenUrl = "/images/elconjuro.jpg",
//            Vistas = 214
//        },
//        new Pelicula
//        {
//            Titulo = "lala land",
//            Descripcion = "Romance y drama",
//            Categoria = "Drama",
//            ImagenUrl = "/images/lalaland.jpeg",
//            Vistas = 160
//        },
//        new Pelicula
//        {
//            Titulo = "Los increíbles",
//            Descripcion = "Superhéroes ",
//            Categoria = "Acción, Animación",
//            ImagenUrl = "/images/losincreibles.jpeg",
//            Vistas = 115
//        }
//    );

//    context.SaveChanges();
}

app.MapGet("/__check-image", (IWebHostEnvironment env) =>
{
    // ajusta el nombre si tu archivo se llama distinto
    string nombre = "elconjuro.jpg";
    string rutaFisica = Path.Combine(env.WebRootPath, "Images", nombre);
    bool existe = System.IO.File.Exists(rutaFisica);
    return Results.Content($"WebRootPath = {env.WebRootPath}\nRuta esperada = {rutaFisica}\nExiste = {existe}");
});

app.Run();