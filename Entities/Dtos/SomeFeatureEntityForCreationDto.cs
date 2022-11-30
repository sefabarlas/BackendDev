using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public class SomeFeatureEntityForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string? Name { get; set; }
    }
}