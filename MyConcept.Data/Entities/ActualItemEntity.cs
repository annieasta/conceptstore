using MyConcept.Data.Enums;

namespace MyConcept.Data.Entities
{
    public class ActualItemEntity : BaseEntity
    {
        public required ProductEntity Product { get; set; }
        public required ActualItemState State { get; set; }
    }
}
