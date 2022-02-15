using MvcMovie.Dietician;

namespace Dietician.Models
{
    public class Publication
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<Recipe>? Recipes { get; set; }
        public ICollection<Chef>? Chefs { get; set; }

    }
}
