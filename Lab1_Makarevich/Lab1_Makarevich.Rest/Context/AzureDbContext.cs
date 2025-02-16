﻿using Lab1_Makarevich.Rest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Makarevich.Rest.Context
{
    public class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions<AzureDbContext> options) : base(options)
        {
        }

        protected AzureDbContext()
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
