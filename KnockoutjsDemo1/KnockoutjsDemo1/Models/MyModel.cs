using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnockoutjsDemo1.Models
{
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string TrackingNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Notes { get; set; }
        public string OrderStatus { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Nullable<short> Quantity { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Order Order { get; set; }
    }
}

/*
    var OrderViewModel= {
        orderBranchId : ko.observable(0),
        orderCustomerId : ko.observable(0),
        orderEmployeeeId : ko.observable(0),
        paymentMethod : ko.observable("Cash"),
        TotalAmount : ko.observable(100),
        paidAmount : ko.observable(0),
        paymentDate : ko.observable(Date.now),
        orderStatus: ko.observable("Open"),
        orderDetails: ko.observableArray([new orderDetail(1, 2, "Test")]),
 */