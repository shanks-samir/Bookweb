﻿
using Bookweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<category> Categories { get; set; }
    }
}
