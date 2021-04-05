using UnityEngine;

namespace Assets.Script.Clickable.Interactable.Objects
{
    public class Telephone : Interactable
    {
        public override void Interact()
        {
            Debug.Log("... in some model regions in North Rhine-Westphalia and Hesse, people can now dial 115 to get in touch with the authorities.");
        }

        public override void Look()
        {
            Debug.Log("Looks like a red Telephone");
        }
    }
}
