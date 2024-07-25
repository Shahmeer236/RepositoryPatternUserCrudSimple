using CrudRepo.Dtos.User;
using CrudRepo.Enities;

namespace CrudRepo.Services.Interface
{
    public interface IUserServices
    {
        Task<List<User>> GetUsersAsync();
        Task<int> AddUserAsync(UserForCreation userForCreation);
        Task<UserDto> GetUserByIdAsync(int id);

        Task<bool> UpdateUserAsync(UserForUpdation userForUpdation);
        Task<bool> DeleteUsersAsync(int id);

    }
}
