using AutoMapper;
using CrudRepo.Dtos.User;
using CrudRepo.Enities;
using CrudRepo.Repositories;
using CrudRepo.Repositories.Interfaces;
using CrudRepo.Services.Interface;

namespace CrudRepo.Services.Implementation
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }

      

        public async Task<int> AddUserAsync(UserForCreation userForCreation)
        {
            return await _userRepository.AddUserAsync(userForCreation);
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);

        }

        public async Task<bool> UpdateUserAsync(UserForUpdation userForUpdation)
        {
            return await _userRepository.UpdateUserAsync(userForUpdation);
        }

        public Task<bool> DeleteUsersAsync(int id)
        {
            return _userRepository.DeleteUsersAsync(id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }
     
    }
}
