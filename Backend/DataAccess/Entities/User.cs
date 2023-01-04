﻿using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities
{
    public class User : IdentityUser<int>
    {
        public User() 
        {
            RegistrationDate = DateTime.UtcNow;
        }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}