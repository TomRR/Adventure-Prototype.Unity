using UnityEngine;

namespace Assets.Script.Clickable.Interactable
{
    public abstract class Interactable : MonoBehaviour, IClickable
    {
        [SerializeField] private Vector2 _targetPosition;

        public Vector2 GetTargetPosition => _targetPosition;
    
        public virtual void Interact() {}
        public virtual void Look() {}
    }
}
