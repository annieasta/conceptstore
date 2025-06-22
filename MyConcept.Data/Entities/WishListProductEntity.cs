namespace MyConcept.Data.Entities
{
    public class WishListProductEntity : BaseEntity
    {
        public required WishListEntity WishList { get; set; }
        public required ProductEntity Product { get; set; }
    }
}
