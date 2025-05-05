namespace Craft.Inventory.Core.Entities
{
    public class Inventorry : BaseEntity
    {
        public Inventorry() { } // for entity framework
        public Inventorry(int quantity,int reorderlevel,string location,DateTimeOffset lastUpdated,string name)
        {
            InventoryId = Guid.NewGuid();
            Quantity = quantity;
            Reorderlevel = reorderlevel;
            Location = location;
            LastUpdated = lastUpdated;
            Name = name;
            CreatedBy = new();
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedOn = DateTimeOffset.Now;
        }
        public List<Product> Products { get; set; } = new();
        public string Name { get; set; } = string.Empty;
        public Guid InventoryId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public int Reorderlevel { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTimeOffset LastUpdated { get; set; }
    }
}
