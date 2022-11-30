using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class SomeFeatureEntity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer then 60 characters")]
        public string? Name { get; set; }

        public ICollection<SomeFeatureDetailEntity>? SomeFeatureDetailEntities { get; set; }
    }
}