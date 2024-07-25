using System.ComponentModel.DataAnnotations;

namespace CrudRepo.Enities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        
        public string Password { get; set; }
    }
}
