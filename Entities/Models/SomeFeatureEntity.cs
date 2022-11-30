using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SomeFeatureEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer then 100 characters")]
        public string? Name { get; set; }

        public ICollection<SomeFeatureDetailEntity>? SomeFeatureDetailEntities { get; set; }
    }
}