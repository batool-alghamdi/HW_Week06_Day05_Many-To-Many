﻿using System;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel>()
                .Property(r => r.RoomNumber)
                .IsRequired();


            //Seeding
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Batool",
                LastName = "Alghamdi",
                Email = "Batool@hotmail.com"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
              Id  = 2 , FirstName = "Abdulaziz", LastName = "Almohammadi",
                Email = "Ezz@hotmail.com"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id  = 3 ,  FirstName = "Abdullah", LastName = "Al heif",
                Email = "Abdullah@hotmail.com"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 4,
                FirstName = "Sameera",
                LastName = "Alhusaini",
                Email = "sameera@hotmail.com"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 5,
                FirstName = "Reema",
                LastName = "AlYousef",
                Email = "reemah@hotmail.com"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 6,
                FirstName = "bayader",
                LastName = "Alghamdi",
                Email = "bayader@hotmail.com"
            });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<SubjectModel> Subject { get; set; }
        public DbSet<StudentTeacherModel> Student_Teacher{ get; set; }
    }
}