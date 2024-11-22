using System.ComponentModel.DataAnnotations;

namespace Eve.Core.Models.Entities
{
    public class Rol
    {
        [Key]
        public Guid RolId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public ActionType Actions { get; set; }
        
        public virtual ICollection<UserLogin> Users { get; set; }
    }

    public enum ActionType
    {
        Low,
        Mid,
        High,
        God
    }
}
