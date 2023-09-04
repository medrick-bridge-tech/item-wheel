using System;
using ItemWheelModule.Model;

namespace ItemWheelModule.Presenter
{
    public class ItemWheel
    {
        public Action<InventoryItem> onWheelItemsAdded;
        public Action<InventoryItem> onWheelItemRemoved;

        public Action<int> onItemSelected;

        public void Setup(ItemWheelModule.Model.ItemWheel itemWheelModel, ItemWheelModule.View.ItemWheel itemWheelView)
        {
            onWheelItemsAdded += (item) => itemWheelView.AddToItemWheel(item);
            onWheelItemRemoved += (item) => itemWheelView.RemoveItem(item);

            onItemSelected += (index) => itemWheelModel.SelectItem(index);
        }
    }
}