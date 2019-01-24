using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class Order:Entity
    {
        public string Description { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public string BillNo { get; set; }
        public string PhotoUrl { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }
        public virtual List<Customer> Customers { get; set; }

    }
}
