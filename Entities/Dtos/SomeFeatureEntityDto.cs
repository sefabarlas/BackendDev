namespace Entities.Dtos
{
    public class SomeFeatureEntityDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<SomeFeatureDetailEntityDto>? SomeFeatureDetailEntities { get; set; }
    }
}