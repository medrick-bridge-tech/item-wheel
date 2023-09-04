using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWheel : MonoBehaviour
{
    public event Action<InventoryItem> onItemAdded; 
    public event Action<InventoryItem> onItemRemoved;

    public List<InventoryItem> _inventoryItems = new List<InventoryItem>();


    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void AddItem(InventoryItem item)
    {
        _inventoryItems?.Add(item);
        ItemAdded(item);
    }
    
    public void ItemAdded(InventoryItem item)
    {
        onItemAdded?.Invoke(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        _inventoryItems?.Remove(item);
        ItemRemoved(item);
    }

    public void ItemRemoved(InventoryItem item)
    {
        onItemRemoved?.Invoke(item);
    }
}
