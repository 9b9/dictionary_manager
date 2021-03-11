using System.Collections.Generic;

namespace service.Data.Models
{
    public class Word
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<WordTranslated> WordTranslateds { get; set; }
    }
}