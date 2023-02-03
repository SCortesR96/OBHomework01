using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OBHomework01.Model.DataModel
{
    public class Course : BaseEntity
    {
        /// <summary>
        /// In OpenBootcamp is missing the complete requirements for this field,
        /// it is just required
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string LongDescription { get; set; } = string.Empty;
        [Required]
        public string PublicTarget { get; set; } = string.Empty;
        [Required]
        public string Targets { get; set; } = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public Levels Levels { get; set; }
    }

    public enum Levels
    {
        [Description("Básico")]
        Basic,
        [Description("Intermedio")]
        Intermediate,
        [Description("Avanzado")]
        Advanced,
    }
}
