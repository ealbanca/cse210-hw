using System;
using System.Reflection.Metadata.Ecma335;

public class Order
{

    private List<Product> _products;
    private Customer _customer;

    private double _UsaShipping = 5;
    private double _InterShipping = 35;

    public Order(List<Product> products, Customer customer, double UsaShipping, double InterShipping)
    {
        _products = products;
        _customer = customer;
        _UsaShipping = UsaShipping;
        _InterShipping = InterShipping;
    }
}