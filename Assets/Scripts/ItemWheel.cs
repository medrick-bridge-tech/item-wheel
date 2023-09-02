using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWheel : MonoBehaviour
{
    public event Action newItemWasAdded; 
    public event Action itemWasRemoved;
    
    public List<InventoryItem> _inventoryItems;


    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void AddItem(InventoryItem item)
    {
        _inventoryItems.Add(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        _inventoryItems.Remove(item);
    }

    // public void OpenWheel()
    // {
    //     wheelOpened.Invoke();
    // }
    //
    // public void CloseWheel()
    // {
    //     wheelClosed.Invoke();
    // }
}
