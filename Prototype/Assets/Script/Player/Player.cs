using Assets.Script.Clickable;
using Assets.Script.Clickable.Interactable;
using UnityEngine;

namespace Assets.Script.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        [Range(5, 35)]
        private const float Speed = 12f;
        [SerializeField]
        [Range(1f, 10f)]
        private const float ScalePlayerHorizon = 2.53f;
        [SerializeField]
        [Range(0f, 10f)]
        private const float ScalePlayerTotal = 1.8f;
        [SerializeField]
        [Range(-20f, 0f)]
        private const float BackgroundLowerBorder = -10f;
        [SerializeField]
        [Range(1f, 10f)]
        private const float TargetPosYCorrection = 3.71f;
    
        private SpriteRenderer _spriteRenderer;
        private Vector2 _targetPosition;
        private bool _isMoving = false;

        public void InteractWith(IClickable clickable)
        {
            SetTargetPosition(clickable);
            _isMoving = true;
        
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
        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
        private void Update()
        {
            if (!_isMoving) return;
            Move();
            UpdateSprite();
        }

        #region Movement

        private void Move()
        {
            transform.position =
                Vector2.MoveTowards(
                    transform.position, 
                    _targetPosition, 
                    Speed * Time.deltaTime
                );
            if (!transform.position.Equals(_targetPosition)) return;
            Debug.Log("Arrive...");
            _isMoving = false;
        }
        private void SetTargetPosition(IClickable clickable)
        {
            if (clickable is Interactable interactable)
            {
                _targetPosition = interactable.GetTargetPosition;
                return;
            }
            _targetPosition = new Vector2(clickable.GetTargetPosition.x, TargetPositionYCorrection(clickable.GetTargetPosition.y));
            Debug.Log(_targetPosition);
        }

        // feet walks to target Position
        private float TargetPositionYCorrection(float y)
        {
            return y + TargetPosYCorrection * CalculatePerspectiveScaling(y);
        }

        #endregion
    

        #region Update Sprite for Movement
    
        private void UpdateSprite()
        {
            FlipSprite();
            ScaleSprite();
        }
        private void FlipSprite()
        {
            _spriteRenderer.flipX = transform.position.x < _targetPosition.x;
        }
        private void ScaleSprite()
        {
            transform.localScale = new Vector2(CalculatePerspectiveScaling(transform.position.y),
                CalculatePerspectiveScaling(transform.position.y));
        }
        private float CalculatePerspectiveScaling(float y)
        {

            float normalization = 1 - (y - BackgroundLowerBorder) / (ScalePlayerHorizon - BackgroundLowerBorder);
            return normalization * ScalePlayerTotal;
        }
    
        #endregion

    }
}
