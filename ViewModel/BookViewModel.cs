using System.ComponentModel.DataAnnotations;

namespace MyLabraryProject.ViewModel
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        [Required, StringLength(50)]

        public string? BookName { get; set; }
        [Required, StringLength(500)]
        public string? Tematic { get; set; }
        [Required]
        public string? Image { get; set; }
    }
}
