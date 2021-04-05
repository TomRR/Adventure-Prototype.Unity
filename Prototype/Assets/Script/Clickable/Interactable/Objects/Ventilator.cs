using UnityEngine;

namespace Assets.Script.Clickable.Interactable.Objects
{
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
}
