using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : InventoryItem
{
    public event Action onItemSelected;

    public void SelectItem()
    {
        onItemSelected?.Invoke();
    }
}
