using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWheel : MonoBehaviour
{
    public event Action<InventoryItem> newItemWasAdded; 
    public event Action<InventoryItem> itemWasRemoved;

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
        NewItemWasAdded(item);
    }
    
    public void NewItemWasAdded(InventoryItem item)
    {
        newItemWasAdded?.Invoke(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        _inventoryItems?.Remove(item);
        ItemWasRemoved(item);
    }

    public void ItemWasRemoved(InventoryItem item)
    {
        itemWasRemoved?.Invoke(item);
    }
}
