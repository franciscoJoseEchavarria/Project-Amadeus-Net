// Importamos las definiciones necesarias para trabajar con Entity Framework Core
using Microsoft.EntityFrameworkCore;
using proyectoBackendAmadeusNet.models;

// Definimos el espacio de nombres para organizar el código
namespace proyectoBackendAmadeusNet.appDataBase
{
    // Definimos la clase AppDbContext que hereda de DbContext
    public class AppDbContext : DbContext
    {
        // Constructor de la clase que recibe opciones de configuración y las pasa a la clase base
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Definimos una propiedad DbSet para la tabla de usuarios
        // DbSet<UserModel> Users: Representa la tabla de usuarios en la base de datos
        public DbSet<UserModel> Users { get; set; }
    }
}