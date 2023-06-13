using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winer : MonoBehaviour
{
    [SerializeField] private GameObject MenuWiner;
    public void YouWin()
    {
        MenuWiner.SetActive(true);
    }
}
