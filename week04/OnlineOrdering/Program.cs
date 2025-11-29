using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("308 Negra Arroyo Lane", "Albuquerque", "NM", "USA");
        Customer c1 = new Customer("Walter White", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 19.99, 2));

        Address a2 = new Address("Calle 45", "Bogotá", "Cundinamarca", "Colombia");
        Customer c2 = new Customer("Sara Lopez", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Phone", "PHN789", 699.99, 1));
        order2.AddProduct(new Product("Charger", "CHG101", 24.99, 1));

        DisplayOrder(order1);
        Console.WriteLine("------------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}
