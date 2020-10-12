using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeClient : MonoBehaviour
{
    private void Update()
    {


        /// <summary>
        /// Espresso
        /// </summary>
        /// <returns></returns>

        if (Input.GetKeyDown(KeyCode.E))
        {//Default Espress
            ICoffee coff = new CoffeeEspresso();
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {//Espress w/milk
            ICoffee coff = new MilkDecorator(new CoffeeEspresso());
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }

        if (Input.GetKeyDown(KeyCode.T))
        {//Espress w/choc
            ICoffee coff = new ChocolateDecorator(new CoffeeEspresso());
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {//Espress w/choc & Milk
            ICoffee coff = new ChocolateDecorator(new MilkDecorator(new CoffeeEspresso()));
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }





        /// <summary>
        /// Filtered
        /// </summary>
        /// <returns></returns>

        if (Input.GetKeyDown(KeyCode.F))
        {//Default Filtered
            ICoffee coff = new CoffeeFiltered();
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }

        if (Input.GetKeyDown(KeyCode.G))
        {//Filtered w/milk
            ICoffee coff = new MilkDecorator(new CoffeeFiltered());
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }

        if (Input.GetKeyDown(KeyCode.H))
        {//Filtered w/choc
            ICoffee coff = new ChocolateDecorator(new CoffeeFiltered());
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }

        if (Input.GetKeyDown(KeyCode.J))
        {//Filtered w/Milk & choc
            ICoffee coff = new MilkDecorator(new ChocolateDecorator(new CoffeeFiltered()));
            Debug.Log("New " + coff.GetDescription() + " Cost: " + coff.GetCost().ToString());
        }


    }
}
