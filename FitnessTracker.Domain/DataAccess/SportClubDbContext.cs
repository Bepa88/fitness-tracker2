using FitnessTracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.DataAccess
{
    public class SportClubDbContext : DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet <Workout> Workouts { get; set; }
        public DbSet <Schedule> Schedules { get; set; }
        public DbSet <Visiting> Visitings { get; set; }

        public SportClubDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\DESKTOP-JQNEKV6;Database=SportClubDb;Trusted_Connection=True;");
        }

    }
}
