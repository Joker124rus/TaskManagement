﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagement.DataAccess;

#nullable disable

namespace TaskManagement.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220720112021_AddMoreSeedData")]
    partial class AddMoreSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskManagement.Domain.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedHours")
                        .HasColumnType("int");

                    b.Property<string>("Executors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IssueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6377),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6369),
                            Description = "Test description.",
                            EstimatedHours = 100,
                            Executors = "Executor",
                            Name = "Issue with inherited estimated hours",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6380),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6380),
                            Description = "Test description.",
                            EstimatedHours = 50,
                            Executors = "Executor",
                            IssueId = 1,
                            Name = "Second issue",
                            Status = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6383),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6382),
                            Description = "Test description.",
                            EstimatedHours = 50,
                            Executors = "Executor",
                            IssueId = 1,
                            Name = "Third issue",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6385),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6384),
                            Description = "Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string Very long string",
                            EstimatedHours = 150,
                            Executors = "Executor",
                            Name = "Issue with huge description",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6387),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6386),
                            EstimatedHours = 150,
                            Executors = "Executor",
                            IssueId = 2,
                            Name = "Child issue",
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6388),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6388),
                            EstimatedHours = 150,
                            Executors = "Executor",
                            IssueId = 5,
                            Name = "Child child issue",
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6390),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6389),
                            EstimatedHours = 150,
                            Executors = "Executor",
                            IssueId = 6,
                            Name = "Child child child issue",
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6392),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6391),
                            EstimatedHours = 150,
                            Executors = "Executor",
                            IssueId = 7,
                            Name = "Child child child issue",
                            Status = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6394),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6393),
                            EstimatedHours = 150,
                            Executors = "Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor",
                            IssueId = 8,
                            Name = "Child child child issue with many executors",
                            Status = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 20, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6396),
                            Deadline = new DateTime(2022, 7, 27, 11, 20, 20, 651, DateTimeKind.Utc).AddTicks(6396),
                            EstimatedHours = 150,
                            Executors = "Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor, Executor",
                            Name = "Issue with very very very very very very very very very very very very very very very very long name",
                            Status = 3
                        });
                });

            modelBuilder.Entity("TaskManagement.Domain.Models.Issue", b =>
                {
                    b.HasOne("TaskManagement.Domain.Models.Issue", null)
                        .WithMany("SubIssues")
                        .HasForeignKey("IssueId");
                });

            modelBuilder.Entity("TaskManagement.Domain.Models.Issue", b =>
                {
                    b.Navigation("SubIssues");
                });
#pragma warning restore 612, 618
        }
    }
}