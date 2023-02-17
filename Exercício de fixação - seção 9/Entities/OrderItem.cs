using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_fixação___seção_9.Entities;

namespace Exercício_de_fixação___seção_9.Entities
{
     class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
            + ", $"
            + Price
            + ", Quantity: "
            + Quantity
            + ", Subtotal: $"
            + SubTotal();
        }
    }
}
