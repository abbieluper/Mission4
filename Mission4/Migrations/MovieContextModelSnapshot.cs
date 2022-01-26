﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Romantic Comedy",
                            Director = "Anne Fletcher",
                            Edited = false,
                            Lent = "",
                            Notes = "This movie is very good and always makes me laugh!",
                            Rating = "PG-13",
                            Title = "The Proposal",
                            Year = "2009"
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy",
                            Director = "Dennis Dugan",
                            Edited = false,
                            Lent = "",
                            Notes = "This movie is a classic feel good!",
                            Rating = "PG-13",
                            Title = "Just Go With It",
                            Year = "2011"
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Comedy",
                            Director = "Dennis Dugan",
                            Edited = false,
                            Lent = "Teddy Bear",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Grownups",
                            Year = "2010"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
