﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymClass.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; }
        public ICollection<GymClass> GymClasses { get; set; }
    }
}
