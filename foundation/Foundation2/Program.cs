using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new Address("920 Wheeler Street", "Idaho Falls", "ID", "USA");
        Address add2 = new Address("353 Firethorn Dr", "Salt Lake", "UT", "USA");
        Address add3 = new Address("151 colon", "Bogota", "Bogota", "Colombia");
        Address add4 = new Address("651 Avenue t", "Sao Paulo", "Sao Paulo", "Brazil");


        Customer cust1 = new Customer("Edwin Albancando", add1);
        Customer cust2 = new Customer("Annie Gordon", add2);
        Customer cust3 = new Customer("Tom Barber", add3);
        Customer cust4 = new Customer("Bryan North", add4);


        Product pro1 = new Product("Tablet 20A", "TA5621", 120.50, 2);
        Product pro2 = new Product("Apple Watch", "AW2109O", 350.00, 1);
        Product pro3 = new Product("TV samsung 75 inches", "SAMTV7530PGT", 1200.99, 3);
        Product pro4 = new Product("Airpods 2 Gen", "AP2GTSDJU", 430.56, 6);
        Product pro5 = new Product("Samsung A25", "SAM25AONGTED", 799.99, 2);
        Product pro6 = new Product("Outside Lights", "OLG312J5GT", 150.99, 4);


        //Product list for order

        List<Product> orderList1 = new List<Product> { pro3, pro6, pro1, pro2 };
        List<Product> orderList2 = new List<Product> { pro1, pro4, pro5 };
        List<Product> orderList3 = new List<Product> { pro1, pro6 };
        List<Product> orderList4 = new List<Product> { pro4, pro5, pro6 };



        Order order1 = new Order(orderList1, cust1, 5, 35);
        Order order2 = new Order(orderList2, cust2, 5, 35);
        Order order3 = new Order(orderList3, cust3, 5, 35);
        Order order4 = new Order(orderList4, cust4, 5, 35);

        //Display every order

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLablel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Subtotal: ${order1.GetTotalOrderCost()}");
        Console.WriteLine($"Shipping Cost: ${order1.GetShippingCost()}");
        Console.WriteLine($"Total: ${order1.GetFinalCost()}\n");
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLablel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Subtotal: ${order2.GetTotalOrderCost()}");
        Console.WriteLine($"Shipping Cost: ${order2.GetShippingCost()}");
        Console.WriteLine($"Total: ${order2.GetFinalCost()}\n");
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Order 3");
        Console.WriteLine(order3.GetPackingLablel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Subtotal: ${order3.GetTotalOrderCost()}");
        Console.WriteLine($"Shipping Cost: ${order3.GetShippingCost()}");
        Console.WriteLine($"Total: ${order3.GetFinalCost()}\n");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Order 4");
        Console.WriteLine(order4.GetPackingLablel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"Subtotal: ${order4.GetTotalOrderCost()}");
        Console.WriteLine($"Shipping Cost: ${order4.GetShippingCost()}");
        Console.WriteLine($"Total: ${order4.GetFinalCost()}\n");
        Console.WriteLine();
        Console.WriteLine();

    }
}