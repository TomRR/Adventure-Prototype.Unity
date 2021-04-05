using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilator : Interactable
{
    public override void Interact()
    {
        Debug.Log("BUEUEUEUEUEHHHE...");
    }

    public override void Look()
    {
        Debug.Log("Looks like a old Ventilator");
    }
}
