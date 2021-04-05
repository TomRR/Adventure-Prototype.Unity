using UnityEngine;

namespace Assets.Script.Clickable.Interactable.NPCs
{
    public class Kolja : Interactable, INpc
    {
        public override void Interact()
        {
            ToggleDialogBox();
            Debug.Log("...Talking to Kolja");
        }

        public override void Look()
        {
            Debug.Log("Looks like a Guy with a nice Ass");
        }

        public void ToggleDialogBox()
        {
            Debug.Log("Toggles Dialogbox - Kolja");
        }
    }
}
