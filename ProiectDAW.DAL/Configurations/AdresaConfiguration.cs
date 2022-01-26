using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProiectDAW.DAL.Entities;

namespace ProiectDAW.DAL.Configurations
{
    public class AdresaConfiguration : IEntityTypeConfiguration<Adresa>
    {
        public void Configure(EntityTypeBuilder<Adresa> builder)
        {
            builder.HasKey(x => x.AdresaId);
            builder.Property(x => x.Strada).HasColumnType("nvarchar(100)").HasMaxLength(100);
            builder.Property(x => x.Numar).HasColumnType("nvarchar(10)").HasMaxLength(10);
            builder.Property(x => x.Oras).HasColumnType("nvarchar(20)").HasMaxLength(20);
            builder.Property(x => x.Judet).HasColumnType("nvarchar(20)").HasMaxLength(20);
        }
    }
}
