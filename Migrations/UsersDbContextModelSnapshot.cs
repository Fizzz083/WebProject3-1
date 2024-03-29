﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApp.Data;

namespace MyWebApp.Migrations
{
    [DbContext(typeof(UsersDbContext))]
    partial class UsersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MyWebApp.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CfId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("CodechefId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LightOjId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("PhoneNUmber")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("_users");
                });
#pragma warning restore 612, 618
        }
    }
}
