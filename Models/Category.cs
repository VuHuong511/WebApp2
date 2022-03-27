using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Display(Name = "Create Date")]
        public DateTime CreatDate { get; set; } = DateTime.UtcNow;
    }
}
