﻿using Ecommerce_Laptops.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class MyAppDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LaptopModel> Laptops { get; set; }

        public DbSet<OrderModel> Orders { get; set; }
    }
}
