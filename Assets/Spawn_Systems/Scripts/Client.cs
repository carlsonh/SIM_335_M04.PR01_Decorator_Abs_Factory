using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{

    public AMFRequirements amfReqs = new AMFRequirements();

    public TextMeshProUGUI spawnedVehicle;
    public TextMeshProUGUI coffeeCost;

    public ICoffee myCoffee;



    private ICoffee GetAMF(AMFRequirements reqs, ICoffee myCoffee)
    {//Get the object with properties from abstrac fac
        AMFFactory _factory = new AMFFactory(reqs, myCoffee);
        return _factory.Create();
    }



    #region UI Setting Coffee Requirements

    public void SetMilkCount(int incMilkCount)
    {
        amfReqs.milkCount = incMilkCount;
    }

    public void SetChocCount(int incChocCount)
    {
        amfReqs.chocCount = incChocCount;
    }
    public void SetAMFType(int amfType)
    {
        amfReqs.coffeeType = (AMFType)amfType;
    }

    public void DestroyCoffee()
    {
        myCoffee = null;
    }


    #endregion UI Setting Coffee Requirements




    public void CreateAMF()
    {

        ICoffee vhc = GetAMF(amfReqs, myCoffee);

        Debug.Log(vhc);
        //Update UI
        spawnedVehicle.text = "Spawned a: " + vhc.GetDescription();
        coffeeCost.text = "Cost: $" + vhc.GetCost();

    }

}
