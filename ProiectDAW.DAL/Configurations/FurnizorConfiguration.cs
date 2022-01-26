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
    public class FurnizorConfiguration : IEntityTypeConfiguration<Furnizor>
    {
        public void Configure(EntityTypeBuilder<Furnizor> builder)
        {
            builder.HasKey(x => x.FurnizorId);
            builder.Property(x => x.Nume).HasColumnType("nvarchar(100)").HasMaxLength(100);
            builder.Property(x => x.Telefon).HasColumnType("nvarchar(20)").HasMaxLength(20);
            builder.Property(x => x.Email).HasColumnType("nvarchar(50)").HasMaxLength(50);
        }
    }
}
