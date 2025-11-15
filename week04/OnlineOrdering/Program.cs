using System;

class Program
{
    static void Main(string[] args)
    {
       
   
        // Customers and addresses
        Address addr1 = new Address("742 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Bobby Wesley", addr1);

        Address addr2 = new Address("45 Ajose Street", "Victoria Island", "Lagos", "Nigeria");
        Customer cust2 = new Customer("Serena Bob", addr2);

        // Orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Soap", "SOAP01", 3, 5));
        order1.AddProduct(new Product("Toothpaste", "TOOTH02", 2, 4));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Shampoo", "SHAMP03", 5, 2));
        order2.AddProduct(new Product("Conditioner", "COND04", 4, 3));

        // Display orders
        order1.DisplayOrder();
        order2.DisplayOrder();
    }
}
