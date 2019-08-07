using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime ReleaseDate{ get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Choose the genre of the movie")]
        public byte? GenreId { get; set; }
        public int NumInStock { get; set; }      
    }
}