using System.Collections;
using System.Collections.Generic;
using Assets.Script.Clickable.Interactable;
using UnityEngine;

public class ItemPickUp : Interactable
{
    public Item Item;
    public override void Interact()
    {
        base.Interact();
        Pickup();
    }

    private void Pickup()
    {
        Debug.Log($"Picking up {Item.name}");
        Inventory.instance.Add(Item);
        Destroy(gameObject);
    }
}
