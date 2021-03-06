﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Videos.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1,20)]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        public int NumberAvailable { get; set; }

        public Genre Genre { get; set; }

    }
}