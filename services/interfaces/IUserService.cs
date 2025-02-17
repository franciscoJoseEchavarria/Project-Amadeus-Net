using proyectoBackendAmadeusNet;
using proyectoBackendAmadeusNet.models;

namespace proyectoBackendAmadeusNet.services.interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> GetUserListAsync();
        Task<UserModel> GetUserByIdAsync(int id);
        Task<UserModel> CreateUserAsync (UserModel userModel);
        Task<UserModel> DeleteUserAsync (int id);
        Task <UserModel> UpdateUserAsync (UserModel userModel);        

    }
    
}