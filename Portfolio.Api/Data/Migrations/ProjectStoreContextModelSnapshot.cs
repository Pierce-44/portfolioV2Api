﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Api.Data;

#nullable disable

namespace Portfolio.Api.Data.Migrations
{
    [DbContext(typeof(ProjectStoreContext))]
    partial class ProjectStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Portfolio.Api.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProjectTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTypeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Portfolio.Api.Entities.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Learning"
                        },
                        new
                        {
                            Id = 2,
                            Name = "React"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dotnet"
                        });
                });

            modelBuilder.Entity("Portfolio.Api.Entities.Project", b =>
                {
                    b.HasOne("Portfolio.Api.Entities.ProjectType", "ProjectType")
                        .WithMany()
                        .HasForeignKey("ProjectTypeId");

                    b.Navigation("ProjectType");
                });
#pragma warning restore 612, 618
        }
    }
}
