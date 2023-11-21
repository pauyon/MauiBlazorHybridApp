using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
