using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tp3_valise.Models;

namespace tp3_valise.Data
{
    public class tp3_valiseContext : IdentityDbContext<ApplicationUser>
    {
        public tp3_valiseContext (DbContextOptions<tp3_valiseContext> options)
            : base(options)
        {

    }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VoyageUser>().HasKey(sc => new { sc.VoyageId, sc.UserId });


        }

        public DbSet<Voyage> Voyage { get; set; }
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<VoyageUser> VoyageUser { get; set; }

    }
}
