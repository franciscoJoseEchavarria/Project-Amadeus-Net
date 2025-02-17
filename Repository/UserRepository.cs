// Importamos las definiciones de interfaces y modelos que necesitamos
using proyectoBackendAmadeusNet.Repository.Interfaces;
using proyectoBackendAmadeusNet.models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using proyectoBackendAmadeusNet.appDataBase;


// Definimos el espacio de nombres para organizar el código
namespace proyectoBackendAmadeusNet.Repository
{
    // Definimos la clase UserRepository
    public class UserRepository : IUserRepository
    {
        // Variable privada para almacenar el contexto de la base de datos
        private readonly AppDbContext _context;

        // Constructor de la clase que recibe el contexto de la base de datos
        public UserRepository(AppDbContext context)
        {
            _context = context; // Asignamos el contexto a la variable privada
        }

        // Método para obtener todos los usuarios de la base de datos de manera asíncrona
        public async Task<IEnumerable<UserModel>> GetUsersAll()
        {
            // Obtenemos la lista de usuarios y la devolvemos
            return await _context.Users.ToListAsync();
        }

        // Método para obtener un usuario por su ID de manera asíncrona
        public async Task<UserModel> GetUserById(int id)
        {
            // Buscamos el usuario con el ID especificado y lo devolvemos
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        // Método para agregar un nuevo usuario a la base de datos de manera asíncrona
        public async Task<UserModel> CreateUser(UserModel user)
        {
            // Agregamos el usuario al contexto
            _context.Users.Add(user);
            // Guardamos los cambios en la base de datos
            await _context.SaveChangesAsync();
            // Devolvemos el usuario agregado
            return user;
        }

        // Método para actualizar un usuario existente en la base de datos de manera asíncrona
        public async Task<UserModel> UpdateUser(UserModel user)
        {
            // Actualizamos el usuario en el contexto
            _context.Users.Update(user);
            // Guardamos los cambios en la base de datos
            await _context.SaveChangesAsync();
            // Devolvemos el usuario actualizado
            return user;
        }

        // Método para eliminar un usuario por su ID de manera asíncrona
        public async Task<UserModel> DeleteUser(int id)
        {
            // Obtenemos el usuario por su ID
            var user = await GetUserById(id);
            // Si el usuario no existe, devolvemos false
            if (user == null)
                return null;
            // Eliminamos el usuario del contexto
            _context.Users.Remove(user);
            // Guardamos los cambios en la base de datos
            await _context.SaveChangesAsync();
            // Devolvemos el usuario eliminado para indicar que la eliminación fue exitosa
            return user;
        }
        // aautenticate user, si contraseña es null, solo se busca por correo
         public async Task<UserModel> AuthenticateUser(string correo, string? contraseña)
        {
            if (contraseña == null)
            {
                return await _context.Users.FirstOrDefaultAsync(u => u.correo == correo);
            }
            // Si la contraseña no es nula, se busca por correo y contraseña
            else
            {
                return await _context.Users
                .FirstOrDefaultAsync(u => u.correo == correo && u.contraseña == contraseña);
            }
            else
            {
                return await _context.Users
                .FirstOrDefaultAsync(u => u.correo == correo && u.contraseña == contraseña);
            }
        }



    }
}