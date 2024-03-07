using System.ComponentModel.DataAnnotations;

namespace pasc24.domain.Entities
{
    public class DefaultEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public required bool IsActive { get; set; }
    }
}