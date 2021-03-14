using System.ComponentModel.DataAnnotations;
using service.Models;

namespace service.Data.Models
{
    public class WordTranslated
    {
        public int Id { get; set; }

        [Required]
        public Language Language { get; set; }

        public string String { get; set; }

        [Required]
        public Word Word { get; set; }
    }
}