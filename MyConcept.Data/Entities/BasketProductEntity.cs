namespace MyConcept.Data.Entities
{
    public class BasketProductEntity : BaseEntity
    {
        public required BasketEntity Basket { get; set; }
        public required ProductEntity Product { get; set; }
    }
}
