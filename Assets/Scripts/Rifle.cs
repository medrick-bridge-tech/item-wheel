using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : InventoryItem
{
    public int Count { get; set; }
    public bool IsActive { get; set; }

    
    public void SetActive(bool isActive)
    {
        IsActive = isActive;
    }
}
