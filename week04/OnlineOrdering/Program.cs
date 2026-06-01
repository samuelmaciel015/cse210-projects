using System;

class Program
{
    static void Main(string[] args)
    {
        //first order
        //create an address
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");

        //create a customer
        Customer customer = new Customer("John Doe", address);

        //create some products
        Product product1 = new Product("Apple", 1, 10.99, 2);
        Product product2 = new Product("Banana", 2, 5.99, 3);
        Product product3 = new Product("Orange", 2, 5.99, 3);

        //create an order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        //display the packing label, shipping label, and total cost
        Console.WriteLine("Order 1:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");

        //second order
        //create an address
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        //create a customer
        Customer customer2 = new Customer("Jane Smith", address2);

        //create some products
        Product product4 = new Product("Grapes", 3, 15.99, 1);
        Product product5 = new Product("Watermelon", 4, 20.99, 1);
        Product product6 = new Product("Pineapple", 5, 12.99, 2);

        //create an order
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        //display the packing label, shipping label, and total cost
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}