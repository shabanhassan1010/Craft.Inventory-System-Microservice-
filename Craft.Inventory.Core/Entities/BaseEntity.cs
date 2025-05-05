namespace Craft.Inventory.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }  // this Id related to database
        public Guid CreatedBy { get; set; }  // User who added anything
        public Guid ModifiedBy { get; set; } // User who modified anything
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }
}
