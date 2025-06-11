using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("West St.", "Paris", "Texas", "USA");
        Customer customer1 = new Customer("Marcos Gray", address1);
        Product product1 = new Product("Phone", "025", 5.6, 2);
        Product product2 = new Product("TV", "026", 10.4, 1);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);

        Order order1 = new Order(customer1, products1);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.DisplayTotalPrice());

        Address address2 = new Address("Av. Oeste", "Luque", "Central", "Paraguay");
        Customer customer2 = new Customer("Carlos Romero", address2);
        Product product3 = new Product("Headphones", "024", 3.2, 2);
        Product product4 = new Product("Laptop", "027", 20.5, 30);

        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);

        Order order2 = new Order(customer2, products2);
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.DisplayTotalPrice());
    }
}