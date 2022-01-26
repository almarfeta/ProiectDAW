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
    public class ProdusConfiguration : IEntityTypeConfiguration<Produs>
    {
        public void Configure(EntityTypeBuilder<Produs> builder)
        {
            builder.HasKey(x => x.ProdusId);
            builder.Property(x => x.Nume).HasColumnType("nvarchar(200)").HasMaxLength(200);
        }
    }
}
