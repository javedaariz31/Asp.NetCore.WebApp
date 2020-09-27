using JM.ImageStoringToDB.EFCore.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JM.ImageStoringToDB.EFCore
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
