namespace MyConcept.Data.Entities
{
    public class GarmentEntity : ProductEntity
    {
        public required string Colour { get; set; }
        public required string Size { get; set; }
    }
}