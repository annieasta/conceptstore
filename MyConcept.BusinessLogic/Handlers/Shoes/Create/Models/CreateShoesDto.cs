namespace MyConcept.BusinessLogic.Handlers.Shoes.Create.Models
{
    public record CreateShoesDto
    {
        public decimal Price { get; set; }
        public required string Name { get; set; }
        public required string Colour { get; set; }
        public required string Size { get; set; }
    }
}
