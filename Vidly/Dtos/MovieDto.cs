using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Genre is required")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "The Release Date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Range(1, 20, ErrorMessage = "The number has to be between 1 and 20")]
        [Required]
        public int NumberInStock { get; set; }
    }
}