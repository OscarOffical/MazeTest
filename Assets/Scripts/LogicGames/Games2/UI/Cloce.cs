using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloce : MonoBehaviour
{
    [SerializeField] public bool _whoOpen;
    public void CloseCanvas(GameObject WhoClose)
    {
       WhoClose.SetActive(_whoOpen);
    }

   
}
