using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tom : Interactable, INpc
{
    public override void Interact()
    {
        Debug.Log("...Talking with Tom.");
    }

    public override void Look()
    {
        Debug.Log("Looks like a Dude with Cap");
    }

    public void ToggleDialogBox()
    {
        throw new System.NotImplementedException();
    }
}
