using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [StringLength(15,MinimumLength = 15)]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$")]
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Price { get; set; }

        public int NumPages { get; set; }


    }
}
