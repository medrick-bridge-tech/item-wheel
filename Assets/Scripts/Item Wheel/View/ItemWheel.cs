using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using ItemWheelModule.Model;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace ItemWheelModule.View
{
    public class ItemWheel : MonoBehaviour
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
                GetInventoryItem(typeof(Knife)).onItemSelected += SelectItem;
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
            if (item is Knife)
            {
                _knifeButton.gameObject.SetActive(true);
                Debug.Log("Knife was added.");
            }
            else if (item is Pistol)
            {
                _pistolButton.gameObject.SetActive(true);
                Debug.Log("Pistol was added.");
            }
            else if (item is Rifle)
            {
                _rifleButton.gameObject.SetActive(true);
                Debug.Log("Rifle was added.");
            }
            else if (item is MachineGun)
            {
                _machineGunButton.gameObject.SetActive(true);
                Debug.Log("Machine gun was added.");
            }
        }
        
        public void RemoveFromItemWheel(InventoryItem item)
        {
            _itemWheel?.RemoveItem(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            if (item is Knife)
            {
                _knifeButton.gameObject.SetActive(false);
                Debug.Log("Knife was removed.");
            }
            else if (item is Pistol)
            {
                _pistolButton.gameObject.SetActive(false);
                Debug.Log("Pistol was removed.");
            }
            else if (item is Rifle)
            {
                _rifleButton.gameObject.SetActive(false);
                Debug.Log("Rifle was removed.");
            }
            else if (item is MachineGun)
            {
                _machineGunButton.gameObject.SetActive(false);
                Debug.Log("Machine gun was removed.");
            }
        }

        public void SelectItem()
        {
            Debug.Log($" was selected");
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
}
