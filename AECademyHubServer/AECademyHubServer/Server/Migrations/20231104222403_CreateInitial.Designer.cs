﻿// <auto-generated />
using System;
using AECademyHubServer.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AECademyHubServer.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231104222403_CreateInitial")]
    partial class CreateInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AECademyHubServer.Shared.Object.Object", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DownloadNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermissionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviewUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reviews")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Objects");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("bc685571-7d85-42b3-90af-8f25afd827f3"),
                            AuthorGuid = new Guid("e4962d2e-3ca4-4716-93fc-777ee8314431"),
                            Description = "Test Description",
                            DownloadNumber = 0,
                            Name = "Test Object",
                            PermissionLevel = "Test Permission Level",
                            PreviewUrl = "Test Preview Url",
                            Reviews = "Test Reviews",
                            Type = "Test Type",
                            Url = "Test Url"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
