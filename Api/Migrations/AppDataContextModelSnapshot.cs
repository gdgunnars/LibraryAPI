﻿// <auto-generated />
using LibraryAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Api.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("LibraryAPI.Models.EntityModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<bool>("Available");

                    b.Property<bool>("Deleted");

                    b.Property<string>("ISBN");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryAPI.Models.EntityModels.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("HasBeenReturned");

                    b.Property<DateTime>("LoanDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("LibraryAPI.Models.EntityModels.Review", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("UserId");

                    b.Property<string>("ReviewText");

                    b.Property<int>("Stars");

                    b.HasKey("BookId", "UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("LibraryAPI.Models.EntityModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
