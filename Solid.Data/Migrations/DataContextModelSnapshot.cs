﻿// <auto-generated />
using System;
using DotenetProject.Solid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Solid.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaxiId")
                        .IsUnique();

                    b.ToTable("Driivers");
                });

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Orderrs");
                });

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Taxi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Taxiies");
                });

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Driver", b =>
                {
                    b.HasOne("DotenetProject.Solid.Core.Enitities.Taxi", "Taxi")
                        .WithOne("Driver")
                        .HasForeignKey("DotenetProject.Solid.Core.Enitities.Driver", "TaxiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taxi");
                });

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Order", b =>
                {
                    b.HasOne("DotenetProject.Solid.Core.Enitities.Driver", "Driver")
                        .WithMany("Orders")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Driver", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DotenetProject.Solid.Core.Enitities.Taxi", b =>
                {
                    b.Navigation("Driver")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
