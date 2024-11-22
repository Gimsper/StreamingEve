using System.ComponentModel.DataAnnotations;

namespace Eve.Core.Models.Entities
{
    public class Source
    {
        [Key]
        public Guid SourceId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public SourceType SourceType { get; set; }

        public virtual ICollection<Media> Media { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }

    public enum SourceType
    {
        Movie,
        Serie
    }
}
