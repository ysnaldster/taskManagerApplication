﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaskManagerApplication.Context;

#nullable disable

namespace TaskManagerApplication.Migrations
{
    [DbContext(typeof(TaskManagerApplicationContext))]
    partial class TaskManagerApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TaskManagerApplication.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("name");

                    b.Property<long>("Time")
                        .HasColumnType("bigint")
                        .HasColumnName("time");

                    b.HasKey("ID");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea2729e"),
                            Description = "",
                            Name = "Pending Activities",
                            Time = 20L
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27202"),
                            Description = "",
                            Name = "Family Activities",
                            Time = 30L
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27219"),
                            Description = "",
                            Name = "Developer Activities",
                            Time = 40L
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27222"),
                            Description = "",
                            Name = "Home Activities",
                            Time = 80L
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27230"),
                            Description = "",
                            Name = "Artistic Activities",
                            Time = 15L
                        });
                });

            modelBuilder.Entity("TaskManagerApplication.Entities.Task", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("author");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(4560))
                        .HasColumnName("creation_date");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("PriorityTask")
                        .HasColumnType("integer")
                        .HasColumnName("priority");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("title");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Task", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27210"),
                            Author = "Ysnaldo",
                            CategoryID = new Guid("c98f14ab-de8c-4883-819b-95de0ea2729e"),
                            CreationDate = new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5374),
                            PriorityTask = 1,
                            Title = "Pay Public Services"
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27211"),
                            Author = "Marta",
                            CategoryID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27202"),
                            CreationDate = new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5384),
                            PriorityTask = 0,
                            Title = "Finish movie in Netflix"
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27212"),
                            Author = "Natalia",
                            CategoryID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27219"),
                            CreationDate = new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5388),
                            PriorityTask = 1,
                            Title = "Make a Java Project"
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27213"),
                            Author = "Marco",
                            CategoryID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27222"),
                            CreationDate = new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5390),
                            PriorityTask = 2,
                            Title = "Clear the house"
                        },
                        new
                        {
                            ID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27214"),
                            Author = "Lucía",
                            CategoryID = new Guid("c98f14ab-de8c-4883-819b-95de0ea27230"),
                            CreationDate = new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5393),
                            PriorityTask = 0,
                            Title = "Drow a Car"
                        });
                });

            modelBuilder.Entity("TaskManagerApplication.Entities.Task", b =>
                {
                    b.HasOne("TaskManagerApplication.Entities.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TaskManagerApplication.Entities.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
