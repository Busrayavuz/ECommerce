using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class OrderDto:Dto
    {
        public string Description { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public string BillNo { get; set; }
        public string PhotoUrl { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual List<OrderLineDto> OrderLines { get; set; }
        public virtual List<CustomerDto> Customers { get; set; }
    }
}
