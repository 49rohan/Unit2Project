using Microsoft.AspNetCore.Mvc;
using Unit2Project.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Unit2Project.Models
{
    public class Anime
    {
        public int AnimeId { get; set;}
        
        [Required(ErrorMessage = "Please enter a anime.")]
        public string? AnimeName { get; set;}

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int? Rating { get; set;}
    }
}