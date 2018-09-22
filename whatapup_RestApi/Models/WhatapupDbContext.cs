using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace whatapup_RestApi.Models
{
    public class WhatapupDbContext :DbContext
    {
        public WhatapupDbContext(DbContextOptions<WhatapupDbContext> options)
            : base(options)
        { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
