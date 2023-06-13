using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class WinZoneTrigger : MonoBehaviour
{
    private Winer _winer;

    [Inject]
    public void Constuct(Winer Win)
    {
        _winer = Win;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if (other.CompareTag("Player"))
            {
                _winer.YouWin();
            }
        }
    }
}
