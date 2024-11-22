using System.ComponentModel.DataAnnotations;

namespace Eve.Core.Models.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Source> Sources { get; set; }
    }
}
