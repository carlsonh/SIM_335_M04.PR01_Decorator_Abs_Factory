using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeEspresso : ICoffee
{
    public float GetCost()
    {
        return 5f;
    }

    public string GetDescription()
    {
        return "Espresso ";
    }
}
