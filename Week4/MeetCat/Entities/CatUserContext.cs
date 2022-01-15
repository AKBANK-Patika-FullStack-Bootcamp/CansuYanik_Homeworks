using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFLibCore
{
    //class is used for db connection
    //DbContext: required for operation on db
    public class CatUserContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public CatUserContext() { }

        //write connection string of db used
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-CST55KG\\SQLEXPRESS; Database = MeetCatDB; integrated security = True;");
        }

        public DbSet<Cat> CatUser { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //transform models to the tables
            modelBuilder.Entity<Cat>().ToTable("Cat");
            modelBuilder.Entity<Gender>().ToTable("Gender");
            modelBuilder.Entity<Log>().ToTable("Log");
        }
    }
}

