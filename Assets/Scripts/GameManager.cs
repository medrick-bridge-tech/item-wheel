using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _wheelImage;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            _wheelImage.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            _wheelImage.SetActive(false);
        }
    }
}
