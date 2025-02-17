using proyectoBackendAmadeusNet;
using System.Collections.Generic;
using proyectoBackendAmadeusNet.models;
using System.Threading.Tasks;


namespace proyectoBackendAmadeusNet.Repository.Interfaces
{
    // Definición de la interfaz IUserRepository
    public interface IUserRepository
    {
        // Método para obtener una lista de usuarios de manera asíncrona
        Task<IEnumerable<UserModel>> GetUsersAll();

        // Método para obtener un usuario por su ID de manera asíncrona
        Task<UserModel> GetUserById(int id);

        // Método para crear un nuevo usuario de manera asíncrona
        Task<UserModel> CreateUser(UserModel user);

        // Método para actualizar un usuario existente de manera asíncrona
        Task<UserModel> UpdateUser(UserModel user);

        // Método para eliminar un usuario por su ID de manera asíncrona
        Task<UserModel> DeleteUser(int id);
    }
}