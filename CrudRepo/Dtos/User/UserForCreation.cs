using System.ComponentModel.DataAnnotations;

namespace CrudRepo.Dtos.User
{
    public class UserForCreation
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        
        public string? Email { get; set; }

        public string? Phone { get; set; }
        
        public string? Password { get; set; }
    }
}
