// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Exercício_de_fixação___seção_9.Entities;
using Exercício_de_fixação___seção_9.Entities.Enums;

namespace course
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status(0 - 3): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Product product = new Product(productName,price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderitem= new OrderItem(quantity, price,product);

                order.AddItem(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
