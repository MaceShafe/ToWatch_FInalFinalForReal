﻿using Microsoft.EntityFrameworkCore;
using ToWatch_FInalFinalForReal.Migrations;
using ToWatch_FInalFinalForReal.Models;

namespace ToWatch_FInalFinalForReal.Data
{
    internal class MoviesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer(
    "Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = MovieToWatch_FinalFinal;Integrated Security = True"
    );

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Priority> Priorities{ get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Seed Users first
                modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Name = "User" });

                // Seed Movies
                modelBuilder.Entity<Movie>().HasData(
                    new Movie { Id = 1, Title = "Avengers"});

                // Seed Genres
                modelBuilder.Entity<Genre>().HasData(
                    new Genre { ID = 1, Name = "Action" },
                    new Genre { ID = 2, Name = "Superhero" },
                    new Genre { ID = 3, Name = "Drama" });

                modelBuilder.Entity<Movie>()
                .HasMany(m => m.Users)
                .WithMany(u => u.Movies)
                .UsingEntity(j => j.ToTable("MovieUsers")); // Custom join table (optional, EF will create one automatically)

            modelBuilder.Entity<Movie>()
    .HasData(
        new { MovieId = 1, UserId = 1 }
    );

        }
    }
    }