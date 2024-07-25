using CrudRepo.Enities;
using Microsoft.EntityFrameworkCore;

namespace CrudRepo.Context
{
    public class CrudRepoDbContext : DbContext
    {
        public CrudRepoDbContext(DbContextOptions<CrudRepoDbContext> options) : base(options) { }
        
        public virtual DbSet<User> Users { get; set; }


    }
}
