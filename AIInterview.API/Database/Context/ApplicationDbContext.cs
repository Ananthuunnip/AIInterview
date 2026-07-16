using AIInterview.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AIInterview.API.Database.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}