using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemWheelPresenter : MonoBehaviour
{
    [Header("Model")] 
    [SerializeField] private ItemWheel _itemWheel;
    
    [Header("View")] 
    [SerializeField] private Image _wheelImage;
    [SerializeField] private Button _knifeButton;
    [SerializeField] private Button _pistolButton;
    [SerializeField] private Button _rifleButton;
    [SerializeField] private Button _machineGunButton;


    void Start()
    {
        if (_itemWheel)
        {
            _itemWheel.onItemAdded += AddItem;
            _itemWheel.onItemRemoved += RemoveItem;
        }
    }
    
    public void OpenWheel()
    {
        _wheelImage?.gameObject.SetActive(true);
    }
    
    public void CloseWheel()
    {
        _wheelImage?.gameObject.SetActive(false);
    }

    public void AddToItemWheel(InventoryItem item)
    {
        _itemWheel?.AddItem(item);
    }

    public void AddItem(InventoryItem item)
    {
        Debug.Log("New item was added.");
        Debug.Log(_itemWheel._inventoryItems.Count);
        
        if (item is Knife)
        {
            _knifeButton.gameObject.SetActive(true);
        }
        else if (item is Pistol)
        {
            _pistolButton.gameObject.SetActive(true);
        }
        else if (item is Rifle)
        {
            _rifleButton.gameObject.SetActive(true);
        }
        else if (item is MachineGun)
        {
            _machineGunButton.gameObject.SetActive(true);
        }
    }
    
    public void RemoveFromItemWheel(InventoryItem item)
    {
        _itemWheel?.RemoveItem(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        Debug.Log("Item was removed.");
        Debug.Log(_itemWheel._inventoryItems.Count);
        
        if (item is Knife)
        {
            _knifeButton.gameObject.SetActive(false);
        }
        else if (item is Pistol)
        {
            _pistolButton.gameObject.SetActive(false);
        }
        else if (item is Rifle)
        {
            _rifleButton.gameObject.SetActive(false);
        }
        else if (item is MachineGun)
        {
            _machineGunButton.gameObject.SetActive(false);
        }
    }

    public InventoryItem GetInventoryItem(Type itemType)
    {
        foreach (var inventoryItem in _itemWheel._inventoryItems)
        {
            if (inventoryItem.GetType() == itemType)
            {
                return inventoryItem;
            }
        }

        return null;
    }
}
