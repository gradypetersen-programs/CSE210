using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("123 Newport Rd", "Newtonville", "California", "USA");
        Address addressTwo = new Address("5678 Gotham St Rd", "Scoville", "Scotland", "UK");

        Customer customerOne = new Customer("Johnny Powers", addressOne);
        Customer customerTwo = new Customer("Charles Holland", addressTwo);

        Order orderOne = new Order(customerOne);
        Order orderTwo = new Order(customerTwo);

        orderOne.AddProduct(new Product("Protein Powder", "98412009832", 16.50, 4));
        orderOne.AddProduct(new Product("Canned Beans", "09322758392", 2.75, 2));
        orderOne.AddProduct(new Product("Chocolate Orange", "56289564314", 4.00, 7));
        orderOne.AddProduct(new Product("Frozen Peas", "00537845278", 2.17, 3));
    
        orderTwo.AddProduct(new Product("Applesauce", "98754375603", 2.00, 4));
        orderTwo.AddProduct(new Product("Authentic Whistling Bottles", "82893194591", 6.00, 3));
        orderTwo.AddProduct(new Product("Banana Puree Drink", "85213583871", 4.50, 3));

        Console.WriteLine(orderOne.MakePackingLabel());
        Console.WriteLine();
        Console.WriteLine(orderOne.MakeShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Total: {orderOne.CalculateTotal():0.00}");
        Console.WriteLine();
        
        Console.WriteLine(orderTwo.MakePackingLabel());
        Console.WriteLine();
        Console.WriteLine(orderTwo.MakeShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Total: {orderTwo.CalculateTotal():0.00}");

    }
}