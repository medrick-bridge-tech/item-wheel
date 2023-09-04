using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour
{
    [SerializeField] private ItemWheelPresenter _itemWheelPresenter;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _itemWheelPresenter?.OpenWheel();
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            _itemWheelPresenter?.CloseWheel();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            _itemWheelPresenter?.AddToItemWheel(new Knife());
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            _itemWheelPresenter?.AddToItemWheel(new Pistol());
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _itemWheelPresenter?.AddToItemWheel(new Rifle());
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            _itemWheelPresenter?.AddToItemWheel(new MachineGun());
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _itemWheelPresenter?.RemoveFromItemWheel(_itemWheelPresenter.GetInventoryItem(typeof(Knife)));
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            _itemWheelPresenter?.RemoveFromItemWheel(_itemWheelPresenter.GetInventoryItem(typeof(Pistol)));
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            _itemWheelPresenter?.RemoveFromItemWheel(_itemWheelPresenter.GetInventoryItem(typeof(Rifle)));
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            _itemWheelPresenter?.RemoveFromItemWheel(_itemWheelPresenter.GetInventoryItem(typeof(MachineGun)));
        }
    }
}
