using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarDoor : Interactable
{
    public override void Interact()
    {
        Debug.Log("...Interacting with the Bar Door.");
    }

    public override void Look()
    {
        Debug.Log("Looks like a Door for the Bar");
    }
}
