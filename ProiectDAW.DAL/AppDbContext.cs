using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectDAW.DAL.Configurations;
using ProiectDAW.DAL.Entities;

namespace ProiectDAW.DAL
{
    //public class AppDbContext : DbContext
    public class AppDbContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clienti { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Furnizor> Furnizori { get; set; }
        public DbSet<Cos> Cosuri { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new AdresaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdusConfiguration());
            modelBuilder.ApplyConfiguration(new FurnizorConfiguration());

            modelBuilder.Entity<Client>().HasOne(a => a.Adresa).WithOne(adr => adr.Client);
            modelBuilder.Entity<Furnizor>().HasMany(a => a.Produse).WithOne(b => b.Furnizor);
            modelBuilder.Entity<Cos>().HasOne(arp => arp.Client).WithMany(a => a.Cos).HasForeignKey(arp => arp.ClientId);
            modelBuilder.Entity<Cos>().HasOne(arp => arp.Produs).WithMany(a => a.Cos).HasForeignKey(arp => arp.ProdusId);
            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });
                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);
            });
        }
    }
}
