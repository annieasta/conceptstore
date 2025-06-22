namespace MyConcept.Data.Entities
{
    public class BasketEntity : BaseEntity
    {
        public List<BasketProductEntity> Products { get; } = new();
        public required CustomerEntity Customer { get; set; }
    }
}
