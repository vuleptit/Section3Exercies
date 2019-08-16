using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "The genre of the movie is required")]
        [Display(Name = "Choose the genre of the movie")]
        public byte? GenreId { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in the Stock")]
        public int NumInStock { get; set; }
        public int NumAvailable { get; set; }
    }
}