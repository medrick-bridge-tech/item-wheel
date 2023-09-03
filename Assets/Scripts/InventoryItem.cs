using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InventoryItem
{
    int Count { get; set; }
    bool IsActive { get; set; }

    void SetActive(bool isActive);
}
