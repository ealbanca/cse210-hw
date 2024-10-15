using System;
using System.Net.Sockets;

public class Customer
{

    private string _name;
    private Address _address;


    public Customer(string name, Address Address)
    {
        _name = name;
        _address = Address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetCompleteAddress();
    }

    public bool isinUSA
    {
        get
        {
            return _address.GetCountry().ToLower() == "usa";
        }
    }
}