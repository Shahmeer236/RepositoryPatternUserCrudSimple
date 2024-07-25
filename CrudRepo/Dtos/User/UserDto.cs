using System.ComponentModel.DataAnnotations;

namespace CrudRepo.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }
    }
}
