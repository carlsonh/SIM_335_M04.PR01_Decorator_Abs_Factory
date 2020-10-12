using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeDecorator : ICoffee
{
    ICoffee _coffee;

    protected string _name = "N/A Coffee add-on";
    protected float _price = 0.0f;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public float GetCost()
    {
        return _coffee.GetCost() + _price;

    }

    public string GetDescription()
    {
        return _coffee.GetDescription() + _name;
    }
}


public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
        _name = "with Milk ";
        _price = 0.25f;
    }
}
public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee)
    {
        _name = "with Chocolate ";
        _price = 0.50f;
    }
}
