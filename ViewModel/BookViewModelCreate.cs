using System.ComponentModel.DataAnnotations;

namespace MyLabraryProject.ViewModel
{
    public class BookViewModelCreate
    {
        [Required, StringLength(50)]
        public string BookName { get; set; }
        [Required, StringLength(500)]
        public string Tematic { get; set; }
        public string? Image { get; set; }
    }
}
