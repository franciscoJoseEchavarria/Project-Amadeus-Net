using proyectoBackendAmadeusNet;
using proyectoBackendAmadeusNet.models;
using proyectoBackendAmadeusNet.Repository.Interfaces;
using proyectoBackendAmadeusNet.services.interfaces;



namespace proyectoBackendAmadeusNet.services{

    public class UserService: IUserService {

        private readonly IUserRepository _userRepository;

        public UserService( IUserRepository userRepository){
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserModel>> GetUserListAsync()
        {
            return await _userRepository.GetUsersAll();
        }
        
        public async Task<UserModel> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserById(id);
        }
        
        public async Task<UserModel> CreateUserAsync(UserModel user)
        {
            return await _userRepository.CreateUser(user);
        }
        
        public async Task<UserModel> UpdateUserAsync(UserModel user)
        {
            return await _userRepository.UpdateUser(user);
        }
        
        public async Task<UserModel> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteUser(id);
        }
         public async Task<UserModel> AuthenticateUserAsync(string correo, string? contraseña)
        {
            return await _userRepository.AuthenticateUser(correo, contraseña);
        }

    }    
    
    }

    







