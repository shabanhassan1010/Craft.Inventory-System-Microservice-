namespace Craft.Inventory.Core.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        //relation with orders
        public int OrderId { get; set; }
        public Order Order { get; set; } = new();

        //relation with products
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public OrderDetail(int quantity, decimal totalPrice)
        {
            OrderDetailId = Guid.NewGuid();
            Quantity = quantity;
            TotalPrice = totalPrice;
            CreatedBy = new();
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedOn = DateTimeOffset.Now;
        }
    }
}