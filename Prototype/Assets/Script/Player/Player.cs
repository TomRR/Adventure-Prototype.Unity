using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(5, 35)]
    private float speed = 12f;
    private SpriteRenderer _spriteRenderer;
    

    private Vector2 _targetPosition;
    private bool _isMoving = false;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_isMoving)
        {
            Move();
        }
    }
    public void InteractWith(IClickable clickable)
    {
        SetTargetPosition(clickable);


        if (clickable is Interactable interactable)
        {
            interactable.Interact();
        }

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
        // Debug.Log("Move");
        transform.position =
            Vector2.MoveTowards(
                transform.position, 
                _targetPosition, 
                speed * Time.deltaTime
            );
        if (transform.position.Equals(_targetPosition))
        {
            _isMoving = false;
        }
    }
    private void SetTargetPosition(IClickable clickable)
    {
        Debug.Log("is in SetTargetPosition");
        // _targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _targetPosition = clickable.GetTargetPosition;
        Debug.Log(_targetPosition);

        _isMoving = true;
    }


}
