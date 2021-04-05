using UnityEngine;

namespace Assets.Script.Clickable.Interactable.Objects
{
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
}
