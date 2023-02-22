using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    //Getters and setters
    public class FormResponse
    {
        [Key]
        [Required]
        public int AppID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }

        public string LentTo { get; set; }
        public string Notes { get; set; }

        //buid foreign key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; } 
    }
}

//category 
//title
//year
//director
//rating 
// edited
//lent to
// notes
