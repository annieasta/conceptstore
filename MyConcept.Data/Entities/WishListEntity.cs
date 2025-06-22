namespace MyConcept.Data.Entities
{
    public class WishListEntity : BaseEntity
    {
        public List<WishListProductEntity> Products { get; } = new();
        public required CustomerEntity Customer { get; set; } 
    }
}
