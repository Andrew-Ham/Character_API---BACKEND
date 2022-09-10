﻿using Microsoft.EntityFrameworkCore;

namespace Andrew_SuperheroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Character> characters { get; set; }
    }
}
