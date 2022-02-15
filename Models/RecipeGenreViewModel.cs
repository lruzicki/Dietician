using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Dietician;
using System.Collections.Generic;

namespace Dietician.Models
{
    public class RecipeGenreViewModel
    {
        public List<Recipe>? Recipes { get; set; }
        public SelectList? Genres { get; set; }
        public string? RecipeGenre { get; set; }
        public string? SearchString { get; set; }
    }
}