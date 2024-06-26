﻿// <auto-generated />
using System;
using HRAdministration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRAdministration.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240622110543_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRAdministration.Models.ApprovalRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Approver")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("LeaveRequest")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ApprovalRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Approver = 6,
                            Comment = "",
                            LeaveRequest = 1,
                            Status = "New"
                        },
                        new
                        {
                            Id = 2,
                            Approver = 6,
                            Comment = "",
                            LeaveRequest = 2,
                            Status = "New"
                        },
                        new
                        {
                            Id = 3,
                            Approver = 7,
                            Comment = "",
                            LeaveRequest = 3,
                            Status = "New"
                        },
                        new
                        {
                            Id = 4,
                            Approver = 7,
                            Comment = "",
                            LeaveRequest = 4,
                            Status = "New"
                        },
                        new
                        {
                            Id = 5,
                            Approver = 8,
                            Comment = "",
                            LeaveRequest = 5,
                            Status = "New"
                        },
                        new
                        {
                            Id = 6,
                            Approver = 9,
                            Comment = "",
                            LeaveRequest = 6,
                            Status = "New"
                        },
                        new
                        {
                            Id = 7,
                            Approver = 10,
                            Comment = "",
                            LeaveRequest = 7,
                            Status = "New"
                        },
                        new
                        {
                            Id = 8,
                            Approver = 11,
                            Comment = "",
                            LeaveRequest = 8,
                            Status = "New"
                        },
                        new
                        {
                            Id = 9,
                            Approver = 12,
                            Comment = "",
                            LeaveRequest = 9,
                            Status = "New"
                        },
                        new
                        {
                            Id = 10,
                            Approver = 13,
                            Comment = "",
                            LeaveRequest = 10,
                            Status = "New"
                        });
                });

            modelBuilder.Entity("HRAdministration.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("OutOfOfficeBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PeoplePartner")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Subdivision")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Doe",
                            OutOfOfficeBalance = 20m,
                            PeoplePartner = 2,
                            Photo = "john_doe_photo.jpg",
                            Position = "Developer",
                            Status = "Active",
                            Subdivision = "IT Department"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Chris Adams",
                            OutOfOfficeBalance = 15m,
                            PeoplePartner = 0,
                            Photo = "chris_adams_photo.jpg",
                            Position = "Marketing Specialist",
                            Status = "Active",
                            Subdivision = "Marketing"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Sarah Smith",
                            OutOfOfficeBalance = 18m,
                            PeoplePartner = 0,
                            Photo = "sarah_smith_photo.jpg",
                            Position = "Financial Analyst",
                            Status = "Active",
                            Subdivision = "Finance Department"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Joseph Choo",
                            OutOfOfficeBalance = 25m,
                            PeoplePartner = 0,
                            Photo = "joseph_choo_photo.jpg",
                            Position = "Operations Manager",
                            Status = "Active",
                            Subdivision = "Operations"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Steve Harding",
                            OutOfOfficeBalance = 22m,
                            PeoplePartner = 0,
                            Photo = "steve_harding_photo.jpg",
                            Position = "Senior Engineer",
                            Status = "Active",
                            Subdivision = "Research and Development"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Laura Croft",
                            OutOfOfficeBalance = 17m,
                            PeoplePartner = 0,
                            Photo = "laura_croft_photo.jpg",
                            Position = "HR Specialist",
                            Status = "Active",
                            Subdivision = "HR Department"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Michael Jones",
                            OutOfOfficeBalance = 19m,
                            PeoplePartner = 0,
                            Photo = "michael_jones_photo.jpg",
                            Position = "System Administrator",
                            Status = "Active",
                            Subdivision = "IT Department"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "James Bond",
                            OutOfOfficeBalance = 16m,
                            PeoplePartner = 0,
                            Photo = "james_bond_photo.jpg",
                            Position = "Security Officer",
                            Status = "Active",
                            Subdivision = "Security"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Haley Whiting",
                            OutOfOfficeBalance = 14m,
                            PeoplePartner = 0,
                            Photo = "haley_whiting_photo.jpg",
                            Position = "Customer Support Specialist",
                            Status = "Active",
                            Subdivision = "Customer Service"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Tim Thomas",
                            OutOfOfficeBalance = 21m,
                            PeoplePartner = 0,
                            Photo = "tim_thomas_photo.jpg",
                            Position = "Sales Executive",
                            Status = "Active",
                            Subdivision = "Sales Department"
                        },
                        new
                        {
                            Id = 11,
                            FullName = "Kacper Odziemczyk",
                            OutOfOfficeBalance = 23m,
                            PeoplePartner = 0,
                            Photo = "kacper_odziemczyk_photo.jpg",
                            Position = "Software Engineer",
                            Status = "Active",
                            Subdivision = "IT Department"
                        },
                        new
                        {
                            Id = 12,
                            FullName = "Michal Grzechowski",
                            OutOfOfficeBalance = 18m,
                            PeoplePartner = 0,
                            Photo = "michal_grzechowski_photo.jpg",
                            Position = "Marketing Manager",
                            Status = "Active",
                            Subdivision = "Marketing"
                        },
                        new
                        {
                            Id = 13,
                            FullName = "Katarzyna Bielik",
                            OutOfOfficeBalance = 16m,
                            PeoplePartner = 0,
                            Photo = "katarzyna_bielik_photo.jpg",
                            Position = "Accountant",
                            Status = "Active",
                            Subdivision = "Finance Department"
                        });
                });

            modelBuilder.Entity("HRAdministration.Models.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AbsenceReason")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Employee")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AbsenceReason = "Vacation",
                            Comment = "",
                            Employee = 1,
                            EndDate = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 2,
                            AbsenceReason = "Medical",
                            Comment = "",
                            Employee = 2,
                            EndDate = new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 3,
                            AbsenceReason = "Family Leave",
                            Comment = "",
                            Employee = 3,
                            EndDate = new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 4,
                            AbsenceReason = "Personal Time Off",
                            Comment = "",
                            Employee = 4,
                            EndDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 5,
                            AbsenceReason = "Sick Leave",
                            Comment = "",
                            Employee = 5,
                            EndDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 6,
                            AbsenceReason = "Maternity Leave",
                            Comment = "",
                            Employee = 6,
                            EndDate = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 7,
                            AbsenceReason = "Training Leave",
                            Comment = "",
                            Employee = 7,
                            EndDate = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 8,
                            AbsenceReason = "Personal Development",
                            Comment = "",
                            Employee = 8,
                            EndDate = new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 9,
                            AbsenceReason = "Study Leave",
                            Comment = "",
                            Employee = 9,
                            EndDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        },
                        new
                        {
                            Id = 10,
                            AbsenceReason = "Remote Work",
                            Comment = "",
                            Employee = 10,
                            EndDate = new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "New"
                        });
                });

            modelBuilder.Entity("HRAdministration.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectManager")
                        .HasColumnType("int");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "",
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 1,
                            ProjectType = "Software Development",
                            StartDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "",
                            ProjectManager = 2,
                            ProjectType = "Marketing Campaign",
                            StartDate = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "",
                            EndDate = new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 3,
                            ProjectType = "Training Program",
                            StartDate = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 4,
                            Comment = "",
                            EndDate = new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 4,
                            ProjectType = "Product Launch",
                            StartDate = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 5,
                            Comment = "",
                            EndDate = new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 5,
                            ProjectType = "Client Onboarding",
                            StartDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 6,
                            Comment = "",
                            EndDate = new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 6,
                            ProjectType = "Event Management",
                            StartDate = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 7,
                            Comment = "",
                            EndDate = new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 7,
                            ProjectType = "Product Enhancement",
                            StartDate = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 8,
                            Comment = "",
                            EndDate = new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 8,
                            ProjectType = "Infrastructure Upgrade",
                            StartDate = new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 9,
                            Comment = "",
                            EndDate = new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 9,
                            ProjectType = "Market Expansion",
                            StartDate = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        },
                        new
                        {
                            Id = 10,
                            Comment = "",
                            EndDate = new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectManager = 10,
                            ProjectType = "Customer Experience Improvement",
                            StartDate = new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Active"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
