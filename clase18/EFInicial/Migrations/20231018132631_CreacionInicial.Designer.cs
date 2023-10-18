﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VeterinariaEF;

#nullable disable

namespace EFInicial.Migrations
{
    [DbContext(typeof(VeterinariaContext))]
    [Migration("20231018132631_CreacionInicial")]
    partial class CreacionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VeterinariaEF.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MascotaId"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("MascotaId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("VeterinariaEF.Veterinario", b =>
                {
                    b.Property<int>("VeterinarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VeterinarioId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeterinarioId");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("VeterinariaEF.Mascota", b =>
                {
                    b.HasOne("VeterinariaEF.Veterinario", "Veterinario")
                        .WithMany("Mascotas")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("VeterinariaEF.Veterinario", b =>
                {
                    b.Navigation("Mascotas");
                });
#pragma warning restore 612, 618
        }
    }
}
