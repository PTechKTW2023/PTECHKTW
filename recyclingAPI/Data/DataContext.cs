﻿using Microsoft.EntityFrameworkCore;

namespace recyclingAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

    }
}
