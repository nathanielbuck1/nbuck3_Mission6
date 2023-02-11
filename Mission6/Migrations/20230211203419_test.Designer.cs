﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(movieFormContext))]
    [Migration("20230211203419_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6.Models.FormResponse", b =>
                {
                    b.Property<int>("AppID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            AppID = 1,
                            Category = "Action",
                            Director = "Nathaniel",
                            Edited = true,
                            LentTo = "Yo MAMA",
                            Notes = "Bombbbb",
                            Rating = "G",
                            Title = "The great one",
                            Year = 1999
                        },
                        new
                        {
                            AppID = 2,
                            Category = "Action",
                            Director = "Buck",
                            Edited = true,
                            LentTo = "Yo MAMA",
                            Notes = "Bombbbb",
                            Rating = "PG",
                            Title = "The last one",
                            Year = 1989
                        },
                        new
                        {
                            AppID = 3,
                            Category = "Action",
                            Director = "Tadao",
                            Edited = true,
                            LentTo = "Yo MAMA",
                            Notes = "Bombbbb.COM",
                            Rating = "PG",
                            Title = "The Mid one",
                            Year = 2020
                        });
                });
#pragma warning restore 612, 618
        }
    }
}