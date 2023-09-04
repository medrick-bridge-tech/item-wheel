using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemWheelModule.Model
{
    public abstract class InventoryItem
    {
        private string itemId;
        public Action OnItemSelected;
        public Action OnItemAdded;
        public Action OnItemRemoved;

        protected InventoryItem(string itemId)
        {
            this.itemId = itemId;
        }
    }
}