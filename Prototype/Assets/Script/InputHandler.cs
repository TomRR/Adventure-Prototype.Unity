using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
        Debug.Log(_player);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var clickable = Helper.GetClickable();
            _player.InteractWith(clickable);
        }
        if (Input.GetMouseButtonDown(1)) 
        {
            var clickable = Helper.GetClickable();
            _player.LookAt(clickable);
        }
        if (Input.GetKeyDown("i") || Input.mouseScrollDelta.y != 0)
        {
            UIController.ToggleInventory();
        }        
        if (Input.GetKeyDown("t") || Input.mouseScrollDelta.y != 0)
        {
            UIController.ToggleMainMenu();
        }
    }
}
