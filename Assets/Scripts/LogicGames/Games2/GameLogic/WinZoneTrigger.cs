using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class WinZoneTrigger : MonoBehaviour
{
    [SerializeField] NextLeaval _nextLeaval;
    private ClipMusic _clipMusic;
    private Winer _winer;

    private void Awake()
    {
        if (_nextLeaval == null) 
        { 
            _nextLeaval = GetComponent<NextLeaval>();
        }

        if(_clipMusic == null)
        {
            _clipMusic = GetComponent<ClipMusic>();
        }

    }

    [Inject]
    public void Constuct(Winer Win)
    {
        _winer = Win;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if (other.gameObject.GetComponent<InputeControler>())
            {
                _winer.YouWin();
                _clipMusic.PlayClip();
                _nextLeaval.NextLeavals();
               

            }
        }
    }

    
}
