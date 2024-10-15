using System;
using System.Dynamic;
using System.Reflection.Emit;
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

    public List<Product> GetProducts()
    {
        return _products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public string GetPackingLablel()
    {
        string packingLabel = "Packing Label\n";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductInfo() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label\n";
        shippingLabel += $"Customer Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
        return shippingLabel;

    }

    public int GetShippingCost()
    {
        int shippingCost = 0;
        if (_customer.isinUSA)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public double GetTotalOrderCost()
    {

        double totalOrderCost = 0;

        foreach (Product product in _products)
        {
            totalOrderCost += product.GetTotalCostOfProduct();
        }
        return totalOrderCost;
    }

    public double GetFinalCost()
    {
        return GetTotalOrderCost() + GetShippingCost();
    }


}