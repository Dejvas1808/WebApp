using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApp.Models.Student> Student { get; set; }
        public DbSet<WebApp.Models.Profesor> Profesor { get; set; }
        public DbSet<WebApp.Models.Predmet> Predmet { get; set; }
        public DbSet<WebApp.Models.Polaganje> Polaganje { get; set; }
    }
}
