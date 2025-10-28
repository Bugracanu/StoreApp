using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public String Name { get; set; } = null!;
        public String City { get; set; } = null!;
        public String Phone { get; set; } = null!;
        public String Email { get; set; } = null!;
        public String AddressLine { get; set; } = null!;
        public List<OrderItem> OrderItems { get; set; } = new();

    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int ProductId { get; set; } 
        public Product Product { get; set; } = null!;
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}