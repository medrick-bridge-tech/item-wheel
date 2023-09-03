using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemWheelPresenter : MonoBehaviour
{
    [Header("Model")] 
    [SerializeField] private ItemWheel _itemWheel;
    
    [Header("View")] 
    [SerializeField] private Image _wheelImage;
    [SerializeField] private Image _knifeImage;
    [SerializeField] private Image _pistolImage;
    [SerializeField] private Image _rifleImage;
    [SerializeField] private Image _machineGunImage;


    void Start()
    {
        if (_itemWheel)
        {
            _itemWheel.newItemWasAdded += OnNewItemWasAdded;
            _itemWheel.itemWasRemoved += OnItemWasRemoved;
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

    public void OnNewItemWasAdded(InventoryItem item)
    {
        Debug.Log("New item was added.");
        Debug.Log(_itemWheel._inventoryItems.Count);
        
        if (item is Knife)
        {
            _knifeImage.gameObject.SetActive(true);
        }
        else if (item is Pistol)
        {
            _pistolImage.gameObject.SetActive(true);
        }
        else if (item is Rifle)
        {
            _rifleImage.gameObject.SetActive(true);
        }
        else if (item is MachineGun)
        {
            _machineGunImage.gameObject.SetActive(true);
        }
    }
    
    public void RemoveFromItemWheel(InventoryItem item)
    {
        _itemWheel?.RemoveItem(item);
    }

    public void OnItemWasRemoved(InventoryItem item)
    {
        Debug.Log("Item was removed.");
        Debug.Log(_itemWheel._inventoryItems.Count);
        
        if (item is Knife)
        {
            _knifeImage.gameObject.SetActive(false);
        }
        else if (item is Pistol)
        {
            _pistolImage.gameObject.SetActive(false);
        }
        else if (item is Rifle)
        {
            _rifleImage.gameObject.SetActive(false);
        }
        else if (item is MachineGun)
        {
            _machineGunImage.gameObject.SetActive(false);
        }
    }

    public InventoryItem GetInventoryItem()
    {
        foreach (var inventoryItem in _itemWheel._inventoryItems)
        {
            if (inventoryItem is Knife)
            {
                return inventoryItem;
            }
        }

        return null;
    }
}
