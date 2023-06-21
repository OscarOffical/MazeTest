using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaval : MonoBehaviour
{
    public int leavel;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
}
