using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        //Call DateApplicationContext constructor
        //When you call constructor, receive a DbContextOptions of type MovieContext
        //Then give it a name --> in this case "options"
        //options inherit from base options of DbContextOptions
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieModel> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieModel>().HasData(

                    new MovieModel
                    {
                        MovieId = 1,
                        Category = "Romantic Comedy",
                        Title = "The Proposal",
                        Year = "2009",
                        Director = "Anne Fletcher",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "",
                        Notes = "This movie is very good and always makes me laugh!"
                    },
                    new MovieModel
                    {
                        MovieId = 2,
                        Category = "Comedy",
                        Title = "Just Go With It",
                        Year = "2011",
                        Director = "Dennis Dugan",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "",
                        Notes = "This movie is a classic feel good!"
                    },
                    new MovieModel
                    {
                        MovieId = 3,
                        Category = "Comedy",
                        Title = "Grownups",
                        Year = "2010",
                        Director = "Dennis Dugan",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "Teddy Bear",
                        Notes = ""
                    }
            );
        }
    }
}
