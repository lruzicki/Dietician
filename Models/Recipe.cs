using Dietician.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dietician.Atributes;

namespace MvcMovie.Dietician
{
    public class Recipe
    {
        private const int _expensive = 500;
        private const int _oldYear = 1960;
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [ToExpensiveValidations]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]  
        public string? Rating { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.ReleaseDate.Year < 1900)
                yield return new ValidationResult("Surely food is that old?", new[] { "RelaseDate" });
            if (this.ReleaseDate.Year > 2022)
                yield return new ValidationResult("Recipe from future!", new[] { "RelaseDate" });
            if (this.ReleaseDate.Month == 7 && this.Price > 50)
                yield return new ValidationResult("...July? And over 50?", new[] { "RelaseDate" });
        }

        //Navigation Properties
        public int? ChefId { get; set; }
        public Chef? chef { get; set; }
        public int? PublicationId { get; set; }
        public Publication? Publication {  get; set; }
    }
} 