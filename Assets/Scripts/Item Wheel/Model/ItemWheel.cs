using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemWheelModule.Model
{
    public class ItemWheel
    {
        public List<InventoryItem> _inventoryItems = new List<InventoryItem>();
        private Presenter.ItemWheel itemWheelPresenter;
        
        private int selectedItemIndex;
        
        public ItemWheel(Presenter.ItemWheel itemWheelPresenter)
        {
            this.itemWheelPresenter = itemWheelPresenter;
        }
    
        public void AddItem(InventoryItem item)
        {
            _inventoryItems.Add(item);
            Debug.Log(_inventoryItems.Count);
            // item.OnItemAdded.Invoke();
            // itemWheelPresenter.OnWheelItemAdded.Invoke(item);
        }
    
        public void RemoveItem(InventoryItem item)
        {
            _inventoryItems.Remove(item);
            Debug.Log(_inventoryItems.Count);
            // item.OnItemRemoved.Invoke();
            // itemWheelPresenter.OnWheelItemRemoved.Invoke(item);
        }
    
        public void SelectItem(int index)
        {
            selectedItemIndex = index;
        }
    }
    
    public enum ChangeType
    {
        ItemAdd, ItemRemove
    }
}