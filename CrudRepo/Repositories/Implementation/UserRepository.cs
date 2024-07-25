using AutoMapper;
using CrudRepo.Context;
using CrudRepo.Dtos.User;
using CrudRepo.Enities;
using CrudRepo.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudRepo.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly CrudRepoDbContext _context;
        private readonly IMapper _mapper;
        public UserRepository(CrudRepoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }




        public async Task<int> AddUserAsync(UserForCreation userForCreation)
        {
            var user = _mapper.Map<User>(userForCreation);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;

        }


        public async Task<bool> DeleteUsersAsync(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            _context.Users.Remove(user);
            var res = await _context.SaveChangesAsync();

            return res > 0;

        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);


            //return _mapper.Map<UserDto>(user);
            return _mapper.Map<UserDto>(user);

        }

        public async Task<List<User>> GetUsersAsync()
        {
            var user = await _context.Users.ToListAsync();

            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<bool> UpdateUserAsync(UserForUpdation userForUpdation)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userForUpdation.Id);

            _mapper.Map(userForUpdation, user);

            var res = await _context.SaveChangesAsync();

            return res > 0;


        }

    }
   
}
