namespace MyConcept.Data.Entities
{
    public class CustomerProductEntity : BaseEntity
    {
        public required CustomerEntity Customer { get; set; }
        public required ProductEntity Product { get; set; }
    }
}
