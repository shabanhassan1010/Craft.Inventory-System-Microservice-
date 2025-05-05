namespace Craft.Inventory.Core.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public float Weight { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public decimal TaxCost { get; set; }
        public decimal ProfitPerUnit { get; set; }
        public decimal ProductionCost { get; set; }
        //relation with category
        public int CategoryId { get; set; }
        public List<Category> Category { get; set; } = new();

        //relation with Inventory
        public int InventoryId { get; set; }
        public Inventorry Inventory { get; set; } = new();

        //relation with Transactions
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = new();

        // relation with order details
        public List<OrderDetail> OrderDetails { get; set; } = new();
    }
}