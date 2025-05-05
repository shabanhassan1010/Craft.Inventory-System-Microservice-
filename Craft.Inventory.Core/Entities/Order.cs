namespace Craft.Inventory.Core.Entities
{
    public class Order : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid SupplierId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public int Status { get; set; }
        public DateTimeOffset ExpectedDeliveryDate { get; set; }
        public int OrderType { get; set; }
        public DateTimeOffset ReceivedDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new();

        public Order() { } // ctor for ef core
        public Order(Guid supplierId,int totalAmount,int status, DateTimeOffset expectedDeliveryDate,int orderType)
        {
            OrderId = Guid.NewGuid();
            SupplierId = supplierId;
            TotalAmount = totalAmount;
            Status = status;
            ExpectedDeliveryDate = expectedDeliveryDate;
            OrderType = orderType;
            CreatedBy = new();
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedOn = DateTimeOffset.Now;
        }
    }
}
