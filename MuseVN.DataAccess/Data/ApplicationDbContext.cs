﻿using Microsoft.EntityFrameworkCore;
using MuseVN.Models;

namespace MuseVNWeb.DataAccess.Data;

public class ApplicationDbContext : DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){
        
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", DisplayOrder = 1},
            new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 }
            );
    }

}