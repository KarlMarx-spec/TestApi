using Microsoft.EntityFrameworkCore;

namespace PeopleApi.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<Man> Men { get; set; }
        public PeopleContext(DbContextOptions<PeopleContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // creating Data Base
        }
        
    }
}