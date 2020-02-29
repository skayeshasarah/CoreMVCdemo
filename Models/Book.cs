﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreMVCdemo.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Bid { get; set; }
        [Display(Name = "Book Title")]
        [Required]
        public string Btitle { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Author Name")]
        public string Authorname { get; set; }
        [Required]
        public string publisher { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Release Date")]
        public DateTime Releasedate { get; set; }
    }
}
