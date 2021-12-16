﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApp.Data;

namespace MyWebApp.Migrations.AddProblemsDb
{
    [DbContext(typeof(AddProblemsDbContext))]
    [Migration("20211216011941_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MyWebApp.Models.AddProblem", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PAddedBy")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2000);

                    b.Property<string>("PIdea")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("PLink")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("PTag")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.HasKey("Pid");

                    b.ToTable("_addProblems");
                });
#pragma warning restore 612, 618
        }
    }
}