using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerWithBird : Interactable
{
    public override void Interact()
    {
        Debug.Log("...Interacting with Speaker");
    }

    public override void Look()
    {
        Debug.Log("Looks like a Speaker with an Bird next to it");
    }
}
