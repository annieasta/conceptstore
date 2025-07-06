namespace MyConcept.Data.Entities
{
    public class CustomerEntity : BaseEntity
    {
        public required string Login { get; set; }
        public required string PasswordHash { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public List<CustomerProductEntity> Products { get; set; } = [];
    }
}
