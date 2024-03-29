﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApp.Data;

namespace MyWebApp.Migrations.ResourceDb
{
    [DbContext(typeof(ResourceDbContext))]
    partial class ResourceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MyWebApp.Models.Resource", b =>
                {
                    b.Property<int>("RId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddedBy")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Datafiles")
                        .HasColumnType("BLOB");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10000);

                    b.Property<string>("ShortDescription")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Topic")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.HasKey("RId");

                    b.ToTable("_Resource");
                });
#pragma warning restore 612, 618
        }
    }
}
