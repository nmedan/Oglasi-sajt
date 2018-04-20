using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oglasi.Models;

namespace Oglasi.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Oglasi.Models.Oglasi> Oglasi { get; set; }
        public DbSet<Kategorije> Kategorije { get; set; }
        public DbSet<Potkategorije> Potkategorije { get; set; }
        public DbSet<Gradovi> Gradovi { get; set; }
        public DbSet<Proizvodi> Proizvodi { get; set; }
        public DbSet<Prodavnice> Prodavnice { get; set; }
        public DbSet<KategorijeProdavnice> KategorijeProdavnice { get; set; }
        public DbSet<Fotografije> Fotografije { get; set; }
        public DbSet<Poruke> Poruke { get; set; }
        public DbSet<OglasiPotkategorije> OglasiPotkategorije{get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OglasiPotkategorije>().HasKey(x=> new {x.OglasiId,  x.PotkategorijeId });
            builder.Entity<OglasiPotkategorije>().HasOne(x => x.Oglas)
            .WithMany(x => x.OglasiPotkategorije)
            .HasForeignKey(x => x.OglasiId);
            builder.Entity<OglasiPotkategorije>().HasOne(x => x.Potkategorija)
            .WithMany(x => x.OglasiPotkagorije)
            .HasForeignKey(x => x.PotkategorijeId);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
