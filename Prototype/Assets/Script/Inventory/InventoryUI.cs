using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = Inventory.instance;
        _inventory.OnItemChangedCallback += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        
        Debug.Log("Update UI");
    }
}
