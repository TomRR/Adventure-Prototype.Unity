using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private SpriteRenderer _spriteRenderer;
    private const float Speed = 0.4f;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void InteractWith(IClickable clickable)
    {
        Move();
        if (clickable is Interactable interactable)
        {
            interactable.Interact();
        }
        Debug.Log("Interact");
    }

    public void LookAt(IClickable clickable)
    {
        if (clickable is Interactable interactable)
        {
            interactable.Look();
        }
    }
    
    private void Move()
    {
        Debug.Log("Move");
    }

}
