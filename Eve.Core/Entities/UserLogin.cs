﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eve.Core.Models.Entities
{
    public class UserLogin
    {
        [Key]
        public Guid UserId { get; set; }

        [ForeignKey("IdRol")]
        public Guid RolId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
