using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAMFFactory
{
    ICoffee Create(AMFRequirements vehicleReqs, ICoffee coffee);
}

public class AMFFactory : AbstractCoffeeFactory
{
    private readonly IAMFFactory _factory;
    private readonly AMFRequirements _requirements;

    private ICoffee coffeeToDeco;

    private readonly AMFMilkDecorator facAMFMilk;
    private readonly AMFChocDecorator facAMFChoc;


    public AMFFactory(AMFRequirements coffeeReqs, ICoffee coffee)
    {
        facAMFChoc = new AMFChocDecorator();
        facAMFMilk = new AMFMilkDecorator();
        Debug.Log("AMFFac'd");

        _factory = coffeeReqs.coffeeType switch //what
        {
            AMFType.Espresso => (IAMFFactory)new AMFEspressoCreator(),
            AMFType.Filtered => (IAMFFactory)new AMFFilteredCreator(),
        };



        _requirements = coffeeReqs;
        coffeeToDeco = coffee;
    }
    public override ICoffee Create()
    {
        if (coffeeToDeco != null)
        {
            coffeeToDeco = _factory.Create(_requirements, coffeeToDeco);
        }
        coffeeToDeco = facAMFChoc.Create(_requirements, coffeeToDeco); ///Bad
        coffeeToDeco = facAMFMilk.Create(_requirements, coffeeToDeco);

        return coffeeToDeco;
    }
}



/// <summary>
/// Generate the base coffee: espresso
/// </summary>
public class AMFEspressoCreator : IAMFFactory
{
    public ICoffee Create(AMFRequirements coffeeReqs, ICoffee coffee)
    {
        coffee = new CoffeeEspresso();

        return coffee;
    }
}


/// <summary>
/// Generate the base coffee: filtered
/// </summary>
public class AMFFilteredCreator : IAMFFactory
{
    public ICoffee Create(AMFRequirements coffeeReqs, ICoffee coffee)
    {
        coffee = new CoffeeFiltered();
        return coffee;
    }
}



/// <summary>
/// Add milk to the coffee
/// </summary>
public class AMFMilkDecorator : IAMFFactory
{
    public ICoffee Create(AMFRequirements espressoReqs, ICoffee coffee)
    {
        Debug.Log("Milked");
        return espressoReqs.milkCount switch
        {
            0 => coffee,
            1 => new MilkDecorator(coffee),
            2 => new MilkDecorator(new MilkDecorator(coffee)),
            _ => coffee
        };
    }
}


/// <summary>
/// Add chocolate to the coffee
/// </summary>
public class AMFChocDecorator : IAMFFactory
{
    public ICoffee Create(AMFRequirements FilteredReqs, ICoffee coffee)
    {
        Debug.Log("Coffeed");
        return FilteredReqs.chocCount switch
        {
            0 => coffee,
            1 => new ChocolateDecorator(coffee),
            2 => new ChocolateDecorator(new ChocolateDecorator(coffee)),
            _ => coffee
        };
    }
}


