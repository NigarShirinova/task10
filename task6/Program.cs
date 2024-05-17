using task6;

public static class Program
{
    public static void Main()
    {
        Product product1 = new Electronic("iphone", 2600, "titanium");
        Product product2 = new Clothes("trousers", 100, "S");
        
        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.RemoveProduct(product1);
        order.GetDetails();
        Console.WriteLine(order.GetTotalAmount());




    }
}