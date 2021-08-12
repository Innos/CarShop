using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarShop.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        public bool IsMechanic { get; set; }
    }
}
