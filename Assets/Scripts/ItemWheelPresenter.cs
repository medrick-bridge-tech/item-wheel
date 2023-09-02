using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemWheelPresenter : MonoBehaviour
{
    [Header("Model")] 
    [SerializeField] private ItemWheel _itemWheel;
    
    [Header("View")] 
    [SerializeField] private GameObject _wheelSprite; 


    void Start()
    {
        
    }
    
    public void OpenWheel()
    {
        _wheelSprite.SetActive(true);
    }
    
    public void CloseWheel()
    {
        _wheelSprite.SetActive(false);
    }
}
