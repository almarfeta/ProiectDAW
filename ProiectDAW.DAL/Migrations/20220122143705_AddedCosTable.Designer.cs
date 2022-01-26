﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectDAW.DAL;

namespace ProiectDAW.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220122143705_AddedCosTable")]
    partial class AddedCosTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Adresa", b =>
                {
                    b.Property<int>("AdresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Judet")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Numar")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Oras")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Strada")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AdresaId");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Adrese");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nume")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ClientId");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Cos", b =>
                {
                    b.Property<int>("CosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.HasKey("CosId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProdusId");

                    b.ToTable("Cosuri");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Furnizor", b =>
                {
                    b.Property<int>("FurnizorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nume")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("FurnizorId");

                    b.ToTable("Furnizori");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Produs", b =>
                {
                    b.Property<int>("ProdusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FurnizorId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.HasKey("ProdusId");

                    b.HasIndex("FurnizorId");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Adresa", b =>
                {
                    b.HasOne("ProiectDAW.DAL.Entities.Client", "Client")
                        .WithOne("Adresa")
                        .HasForeignKey("ProiectDAW.DAL.Entities.Adresa", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Cos", b =>
                {
                    b.HasOne("ProiectDAW.DAL.Entities.Client", "Client")
                        .WithMany("Cos")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectDAW.DAL.Entities.Produs", "Produs")
                        .WithMany("Cos")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Produs", b =>
                {
                    b.HasOne("ProiectDAW.DAL.Entities.Furnizor", "Furnizor")
                        .WithMany("Produse")
                        .HasForeignKey("FurnizorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Furnizor");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Client", b =>
                {
                    b.Navigation("Adresa");

                    b.Navigation("Cos");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Furnizor", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("ProiectDAW.DAL.Entities.Produs", b =>
                {
                    b.Navigation("Cos");
                });
#pragma warning restore 612, 618
        }
    }
}
