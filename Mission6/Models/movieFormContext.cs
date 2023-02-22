using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class movieFormContext : DbContext
    {
        //Constructor
        public movieFormContext (DbContextOptions<movieFormContext> options): base(options)
        {
            //leave blank for now

        }

        public DbSet<FormResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Load em up! Seed em baby!!!!
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 3, CategoryName = "Comedy" },
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 6, CategoryName = "Television" },
                new Category { CategoryID = 7, CategoryName = "VHS" },
                new Category { CategoryID = 8, CategoryName = "Other" }

                );


            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {

                    //category
                      //title
                      //year
                      //director
                      //rating
                      // edited
                      //lent to
                      // notes*@
                    AppID = 1,
                    CategoryID = 1,
                    Title = "The great one",
                    Year = 1999,
                    Director = "Nathaniel",
                    Rating = "G",
                    Edited = true,
                    LentTo = "Yo MAMA",
                    Notes= "Bombbbb"
                },
                new FormResponse
                {
                    AppID = 2,
                    CategoryID = 1,
                    Title = "The last one",
                    Year = 1989,
                    Director = "Buck",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Yo MAMA",
                    Notes = "Bombbbb"
                },
                new FormResponse
                {
                    AppID = 3,
                    CategoryID = 2,
                    Title = "The Mid one",
                    Year = 2020,
                    Director = "Tadao",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Yo MAMA",
                    Notes = "Bombbbb.COM"
                }

                );
        }
    }
}
