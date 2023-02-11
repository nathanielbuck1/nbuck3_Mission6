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

        public DbSet<FormResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
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
                    Category = "Action",
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
                    Category = "Action",
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
                    Category = "Action",
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
