﻿using System.ComponentModel.DataAnnotations;

namespace OBHomework01.Model.DataModel
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? DeleteAt { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
    }
}
