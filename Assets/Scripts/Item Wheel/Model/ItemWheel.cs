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
            item.OnItemAdded.Invoke();
            itemWheelPresenter.onWheelItemsAdded.Invoke(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            _inventoryItems.Remove(item);
            item.OnItemRemoved.Invoke();
            itemWheelPresenter.onWheelItemRemoved.Invoke(item);
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