using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolja : Interactable, INpc
{
    public override void Interact()
    {
        Debug.Log("...Talking to Kolja");
    }

    public override void Look()
    {
        Debug.Log("Looks like a Guy with a nice Ass");
    }

    public void ToggleDialogBox()
    {
        throw new System.NotImplementedException();
    }
}
