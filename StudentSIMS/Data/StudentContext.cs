using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentSIMS.Models;
using System;

namespace StudentSIMS.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        // Use DbSet<Student> to query or read and write information about A Student
        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }
        public static System.Collections.Specialized.NameValueCollection AppSettings { get; }

        // configure the database to be used by this context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();

            // schoolSIMSConnection is the key of the connection string
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("schoolSIMSConnection"));
        }
    }
}