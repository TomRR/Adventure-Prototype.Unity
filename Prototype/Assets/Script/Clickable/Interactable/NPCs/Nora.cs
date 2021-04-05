using UnityEngine;

namespace Assets.Script.Clickable.Interactable.NPCs
{
    public class Nora : Interactable, INpc
    {
        public override void Interact()
        {
            ToggleDialogBox();
            Debug.Log("...Talking with Nora");
        }

        public override void Look()
        {
            Debug.Log("Looks like a Girl with blue Hair");
        }

        public void ToggleDialogBox()
        {
            Debug.Log("Toggles Dialogbox - Nora");
        }
    }
}
