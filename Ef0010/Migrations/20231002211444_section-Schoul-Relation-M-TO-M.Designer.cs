﻿// <auto-generated />
using System;
using Ef0010.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ef0010.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231002211444_section-Schoul-Relation-M-TO-M")]
    partial class sectionSchoulRelationMTOM
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ef0010.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Mathmatics",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("Ef0010.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Ahmed",
                            LName = "Abdullah",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            FName = "Yasmeen",
                            LName = "Yasmeen",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            FName = "Khalid",
                            LName = "Hassan",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            FName = "Nadia",
                            LName = "Ali",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            FName = "Ahmed",
                            LName = "Abdullah",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("Ef0010.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "building A",
                            OfficeName = "Off_05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "building B",
                            OfficeName = "Off_12"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Adminstration",
                            OfficeName = "Off_32"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_44"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_43"
                        });
                });

            modelBuilder.Entity("Ef0010.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Daily",
                            WED = true
                        },
                        new
                        {
                            Id = 2,
                            FRI = false,
                            MON = false,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "DayAfterDay",
                            WED = false
                        },
                        new
                        {
                            Id = 3,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Twice-a-Week",
                            WED = true
                        },
                        new
                        {
                            Id = 4,
                            FRI = true,
                            MON = false,
                            SAT = true,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Weekend",
                            WED = false
                        },
                        new
                        {
                            Id = 5,
                            FRI = true,
                            MON = true,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Compact",
                            WED = true
                        });
                });

            modelBuilder.Entity("Ef0010.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            SectionName = "S_MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            SectionName = "S_MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            InstructorId = 1,
                            SectionName = "S_PH1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            InstructorId = 3,
                            SectionName = "S_PH2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            InstructorId = 2,
                            SectionName = "S_CH1"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            InstructorId = 3,
                            SectionName = "S_CH2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "S_BI1"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            InstructorId = 5,
                            SectionName = "S_BI2"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS1"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 5,
                            InstructorId = 5,
                            SectionName = "S_CS2"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS3"
                        });
                });

            modelBuilder.Entity("Ef0010.Entities.SectionSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionSchedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 1,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 2,
                            StartTime = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 3,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 4,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 5,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 2,
                            SectionId = 6,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 7,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 8,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 9,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 10,
                            StartTime = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            ScheduleId = 5,
                            SectionId = 11,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("Ef0010.Entities.Instructor", b =>
                {
                    b.HasOne("Ef0010.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("Ef0010.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("Ef0010.Entities.Section", b =>
                {
                    b.HasOne("Ef0010.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ef0010.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Ef0010.Entities.SectionSchedule", b =>
                {
                    b.HasOne("Ef0010.Entities.Schedule", null)
                        .WithMany("SectionSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ef0010.Entities.Section", null)
                        .WithMany("SectionSchedules")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ef0010.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Ef0010.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Ef0010.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Ef0010.Entities.Schedule", b =>
                {
                    b.Navigation("SectionSchedules");
                });

            modelBuilder.Entity("Ef0010.Entities.Section", b =>
                {
                    b.Navigation("SectionSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
