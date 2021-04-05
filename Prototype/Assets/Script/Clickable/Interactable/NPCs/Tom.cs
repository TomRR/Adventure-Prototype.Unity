using UnityEngine;

namespace Assets.Script.Clickable.Interactable.NPCs
{
    public class Tom : Interactable, INpc
    {
        public override void Interact()
        {
            ToggleDialogBox();
            Debug.Log("...Talking with Tom.");
        }

        public override void Look()
        {
            Debug.Log("Looks like a Dude with Cap");
        }

        public void ToggleDialogBox()
        {
            Debug.Log("Toggles Dialogbox - Tom");
        }
    }
}
