using System;
using ItemWheelModule.Model;

namespace ItemWheelModule.Presenter
{
    public class ItemWheel
    {
        public Action<InventoryItem> OnWheelItemAdded;
        public Action<InventoryItem> OnWheelItemRemoved;

        public Action<int> OnItemSelected;
        
        
        public void Setup(ItemWheelModule.Model.ItemWheel itemWheelModel, ItemWheelModule.View.ItemWheel itemWheelView)
        {
            OnWheelItemAdded += (item) => itemWheelModel.AddItem(item);
            OnWheelItemRemoved += (item) => itemWheelModel.RemoveItem(item);

            OnItemSelected += (index) => itemWheelModel.SelectItem(index);
        }
    }
}