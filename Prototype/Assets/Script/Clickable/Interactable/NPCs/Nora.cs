using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nora : Interactable, INpc
{
    public override void Interact()
    {
        Debug.Log("...Talking with Nora");
    }

    public override void Look()
    {
        Debug.Log("Looks like a Girl with blue Hair");
    }

    public void ToggleDialogBox()
    {
        throw new System.NotImplementedException();
    }
}
