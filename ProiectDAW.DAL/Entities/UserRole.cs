﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProiectDAW.DAL.Entities
{
    public class UserRole : IdentityUserRole<int>
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
