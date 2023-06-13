using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstens : MonoBehaviour
{
    
    public GameObject _star;

    private void Awake()
    {
       
            _star = gameObject.transform.GetChild(1).gameObject;
        
    }
}
