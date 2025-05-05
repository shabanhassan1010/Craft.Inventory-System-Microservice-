﻿
namespace Craft.Inventory.Core.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid TransactionId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTimeOffset TransactionDate { get; set; }
        public int Quantity { get; set; }
        public int TransactionType { get; set; }
        public string Notes { get; set; } = string.Empty;

        //relation with products
        public List<Product> Products { get; set; } = new();
        public Transaction() { } // ef core ctor

        public Transaction(Guid employeeId,DateTimeOffset transactionDate, int quantity,int transactionType,string notes)
        {
            TransactionId = Guid.NewGuid();
            EmployeeId = employeeId;
            TransactionDate = transactionDate;
            Quantity = quantity;
            TransactionType = transactionType;
            Notes = notes;
            CreatedBy = employeeId;
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = Guid.Empty;
            ModifiedOn = DateTimeOffset.Now;
        }
    }
}
