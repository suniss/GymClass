﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymClass.Data
{
    public class GymClassDbContext : IdentityDbContext
    {
        public DbSet<GymClassDbContext> GymClass { get; set; }
        public GymClassDbContext(DbContextOptions<GymClassDbContext> options)
            : base(options)
        {
        }
    }
}
