using UnityEngine;

namespace Assets.Script.Clickable.Interactable.Objects
{
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
}
