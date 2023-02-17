using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_fixação___seção_9.Entities.Enums;



namespace Exercício_de_fixação___seção_9.Entities
{
     class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Item) //para cada item na lista Item, ele vai somar o subtotal
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment:" + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total());

            return sb.ToString();
        }
    }
}
