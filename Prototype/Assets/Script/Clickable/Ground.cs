using UnityEngine;

namespace Assets.Script.Clickable
{
    public class Ground : MonoBehaviour, IClickable
    {
        // public Vector2 GetTargetPosition => Camera.main.ScreenToWorldPoint(Input.mousePosition);
        public Vector2 GetTargetPosition => Helper.Get2DWorldMousePosition();
    }
}
