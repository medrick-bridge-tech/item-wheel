using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemWheelModule.Model
{
    public class InventoryItem
    {
        public string _itemId;
        public GameObject _itemButton;
        public Action OnItemSelected;
        public Action OnItemAdded;
        public Action OnItemRemoved;

        public InventoryItem(string itemId, GameObject itemButton)
        {
            _itemId = itemId;
            _itemButton = itemButton;
        }
    }
}