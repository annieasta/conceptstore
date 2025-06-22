namespace MyConcept.Data.Entities
{
    public class ProductEntity : BaseEntity
    {
        public decimal Price { get; set; }
        public required string Name { get; set; }
        public List<BasketProductEntity> Baskets { get; } = new();
        public List<WishListProductEntity> WishLists { get; } = new();
        public List<ActualItemEntity> ActualItems { get; } = new();
    }
}
