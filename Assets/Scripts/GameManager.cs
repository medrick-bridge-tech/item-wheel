using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;


public class GameManager : MonoBehaviour
{
    [FormerlySerializedAs("_itemWheelPresenter")] [SerializeField] private ItemWheel itemWheel;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            itemWheel?.OpenWheel();
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            itemWheel?.CloseWheel();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            itemWheel?.AddToItemWheel(new Knife());
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            itemWheel?.AddToItemWheel(new Pistol());
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            itemWheel?.AddToItemWheel(new Rifle());
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            itemWheel?.AddToItemWheel(new MachineGun());
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            itemWheel?.RemoveFromItemWheel(itemWheel.GetInventoryItem(typeof(Knife)));
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            itemWheel?.RemoveFromItemWheel(itemWheel.GetInventoryItem(typeof(Pistol)));
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            itemWheel?.RemoveFromItemWheel(itemWheel.GetInventoryItem(typeof(Rifle)));
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            itemWheel?.RemoveFromItemWheel(itemWheel.GetInventoryItem(typeof(MachineGun)));
        }
    }
}
