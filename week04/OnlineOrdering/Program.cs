using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        //order 1
        Product product1 = new Product("Apple", 1, .75, 7);
        Product product2 = new Product("Rice", 2, 3.5, 2);
        Product product3 = new Product("Soup", 3, 1.75, 2);

        Address address1 = new Address("800 S Figueroa Street", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Lira", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("ORDER 1");
        order1.MakePackingLabel();
        order1.MakeShippingLabel();
        order1.OrderTotalCost();

        //order 2
        Product product4 = new Product("Graples", 4, .20, 30);
        Product product5 = new Product("Juice", 5, 1.25, 5);
        Product product6 = new Product("Bacon", 6, 4.5, 3);

        Address address2 = new Address("Rua João Gonçalves 21", "Guarulhos", "SP", "BR");
        Customer customer2 = new Customer("Samuel Maciel", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("ORDER 2");
        order2.MakePackingLabel();
        order2.MakeShippingLabel();
        order2.OrderTotalCost();
    }
}