using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAMF
{
    //Unity, at this time, does not support default interface implements >:C
    //Don't know if this would fix the constructor problem either way

    // public void Constructor(bool bUseGravity)
    // {
    //     GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation);
    //     go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    // }
}


//Animals
public class Croc : IAMF
{
    public Croc(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}
public class Bird : IAMF
{
    public Bird(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}
public class Red_Kayle : IAMF
{
    public Red_Kayle(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}

//Mechanical
public class Car : IAMF
{
    public Car(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}

public class Helicopter : IAMF
{
    public Helicopter(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}

//Failures
public class Penguin : IAMF
{
    public Penguin(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}
public class Morgana : IAMF
{
    public Morgana(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}
public class Kayle_11 : IAMF
{
    public Kayle_11(bool bUseGravity)
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(this.GetType().Name), new Vector3(0f, 0.5f, 0f), Random.rotation); //Get class name here
        go.GetComponent<Rigidbody>().useGravity = bUseGravity;
    }
}
