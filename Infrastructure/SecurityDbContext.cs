﻿using DomainModel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class SecurityDbContext : IdentityDbContext<AppUser>
    {
    
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options)
        {

        }
    }
}
