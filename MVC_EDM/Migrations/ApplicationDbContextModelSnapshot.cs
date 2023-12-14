﻿// <auto-generated />
using System;
using MVC_EDM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_EDM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_EDM.Models.DeletedProfile", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadharnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamLead")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressline1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressline2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateofbirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateofjoining")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hrpartner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("mailid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("salary")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("DeletedProfiles");
                });

            modelBuilder.Entity("MVC_EDM.Models.EmployeeProfile", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadharnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamLead")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressline1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressline2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateofbirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateofjoining")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hrpartner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("mailid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("salary")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeProfiles");
                });

            modelBuilder.Entity("MVC_EDM.Models.Request", b =>
                {
                    b.Property<int>("Sno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sno"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requestfor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sno");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}