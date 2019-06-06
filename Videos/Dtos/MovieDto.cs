using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Videos.Models;

namespace Videos.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }

        public GenreDto Genre { get; set; }
    }
}