using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        else if (Input.GetKeyUp(KeyCode.A))
        {
            _itemWheelPresenter?.CloseWheel();
        }
    }
}
