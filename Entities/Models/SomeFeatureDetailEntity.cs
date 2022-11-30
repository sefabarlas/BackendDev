using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SomeFeatureDetailEntity
    {
        public Guid Id { get; set; }
        public Guid SomeFeatureEntityId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [ForeignKey(nameof(SomeFeatureEntity))]
        public SomeFeatureEntity? SomeFeatureEntity { get; set; }
    }
}