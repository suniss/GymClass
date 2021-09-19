using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
//using GymClass.Models.ViewModels.Students;
//using GymClass.Models.Entities;

namespace GymClass.Data
{
    public class GymClassDbContext : IdentityDbContext
    {
        public DbSet<GymClassDbContext>ApplicationUser { get; set; }
       // public DbSet<GymClass.Models.Entities.GymClass> GymClass { get; set; }

        public GymClassDbContext(DbContextOptions<GymClassDbContext> options)
            : base(options)
        {
        }
    }
}
