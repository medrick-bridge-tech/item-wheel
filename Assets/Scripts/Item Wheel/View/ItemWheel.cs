using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        [SerializeField] private GameObject _knifeButton;
        [SerializeField] private GameObject _pistolButton;
        [SerializeField] private GameObject _rifleButton;
        [SerializeField] private GameObject _machineGunButton;
        [SerializeField] private List<InventoryItem> _items = new List<InventoryItem>();
        
        
        private ItemWheelModule.Model.ItemWheel model;
        private ItemWheelModule.Presenter.ItemWheel presenter;
        
        public float radius;
        public float startAngle = 0f;
        
        
        void Start()
        {
            presenter = new ItemWheelModule.Presenter.ItemWheel();
            model = new ItemWheelModule.Model.ItemWheel(presenter);
            presenter.Setup(model, this);
        }
        
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                var newItem = new InventoryItem("Knife", _knifeButton);
                AddToItemWheel(newItem);
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                var newItem = new InventoryItem("Pistol", _pistolButton);
                AddToItemWheel(newItem);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                var newItem = new InventoryItem("Rifle", _rifleButton);
                AddToItemWheel(newItem);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                var newItem = new InventoryItem("Machine gun", _machineGunButton);
                AddToItemWheel(newItem);
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                RemoveFromItemWheel(GetInventoryItemIndex("Knife"));
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                RemoveFromItemWheel(GetInventoryItemIndex("Pistol"));
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                RemoveFromItemWheel(GetInventoryItemIndex("Rifle"));
            }
            else if (Input.GetKeyDown(KeyCode.V))
            {
                RemoveFromItemWheel(GetInventoryItemIndex("Machine gun"));
            }
        }
        

        public void UpdateItemWheelArrangement()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                float angle = startAngle + (360f / _items.Count) * i;
                float angleInRadians = Mathf.Deg2Rad * angle;
                float x = Mathf.Sin(angleInRadians) * radius;
                float y = Mathf.Cos(angleInRadians) * radius;

                Vector3 position = new Vector3(x, y, 0f);

                GameObject item = transform.Find("ItemButton" + i.ToString())?.gameObject;

                if (item == null)
                {
                    item = Instantiate(_items[i]._itemButton, position, transform.rotation, transform);
                    item.name = "ItemButton" + i.ToString();
                }
                else
                {
                    item.transform.position = position;
                    item.transform.rotation = transform.rotation;
                }
            }
        }
        
        public void SelectItem()
        {
            Debug.Log("Item selected");
        }
    
        public void AddToItemWheel(InventoryItem item)
        {
            _items.Add(item);
            presenter.OnWheelItemAdded.Invoke(item);
            UpdateItemWheelArrangement();
        }
        
        public void RemoveFromItemWheel(int itemIndex)
        {
            _items.RemoveAt(itemIndex);
            GameObject obj = GameObject.Find("ItemButton" + itemIndex.ToString());
            if (obj != null)
            {
                Destroy(obj);
            }
            //presenter.OnWheelItemRemoved.Invoke(item);
            UpdateItemWheelArrangement();
        }
        
        public InventoryItem GetInventoryItem(string itemId)
        {
            foreach (var inventoryItem in _items)
            {
                if (inventoryItem._itemId == itemId)
                {
                    return inventoryItem;
                }
            }
    
            return null;
        }
        
        public int GetInventoryItemIndex(string itemId)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i]._itemId == itemId)
                {
                    return i;
                }
            }
    
            return -1;
        }
    }
}
