using System.ComponentModel.DataAnnotations;

namespace CrudRepo.Dtos.User
{
    public class UserforListing
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

       
    }
}
