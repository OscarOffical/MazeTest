using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeavalManager : MonoBehaviour
{
    [SerializeField] private Button[] _leaver;
    [SerializeField] private Leaval _leaval;
    private void Awake()
    {
        _leaval = FindObjectOfType<Leaval>();
        var c = _leaval.leavel;
        _leaver[c].interactable = true;
    }



    

   

    
}
