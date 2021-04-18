using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Inventory Singleton

    public static Inventory instance;
    
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();

    public OnItemChanged OnItemChangedCallback;

    public List<Item> Items = new List<Item>();

    public void Add(Item item)
    {
        Items.Add(item);
        
        if(OnItemChangedCallback != null)
            OnItemChangedCallback.Invoke();
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
        
        if(OnItemChangedCallback != null)
            OnItemChangedCallback.Invoke();
    }
}
