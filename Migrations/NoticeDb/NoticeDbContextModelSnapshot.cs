﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApp.Data;

namespace MyWebApp.Migrations.NoticeDb
{
    [DbContext(typeof(NoticeDbContext))]
    partial class NoticeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MyWebApp.Models.Notice", b =>
                {
                    b.Property<int>("NId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(1550);

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Time")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("NId");

                    b.ToTable("_notices");
                });
#pragma warning restore 612, 618
        }
    }
}
