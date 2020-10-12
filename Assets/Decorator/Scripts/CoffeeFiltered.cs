using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeFiltered : ICoffee
{
    public float GetCost()
    {
        return 3f;
    }

    public string GetDescription()
    {
        return "Filtered ";
    }
}
