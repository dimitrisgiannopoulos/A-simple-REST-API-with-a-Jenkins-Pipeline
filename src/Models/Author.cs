using System.ComponentModel.DataAnnotations;

namespace BookCatalogueAPI.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public virtual List<Book>? Books { get; set; }
    }
}
