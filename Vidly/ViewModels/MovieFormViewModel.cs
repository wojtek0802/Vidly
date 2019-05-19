using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    { 
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }


        public List<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Genre is required")]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "The Release Date is required")]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20, ErrorMessage = "The number has to be between 1 and 20")]
        [Display(Name = "Number In Stock")]
        [Required]
        public int? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit movie" : "New movie";
            }
        }
    }

   
}