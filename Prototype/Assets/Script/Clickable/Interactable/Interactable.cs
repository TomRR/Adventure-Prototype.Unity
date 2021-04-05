using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour, IClickable
{
    [SerializeField] private Vector2 _targetPosition;

    public Vector2 GetTargetPosition => _targetPosition;
    
    public virtual void Interact() {}
    public virtual void Look() {}
}
