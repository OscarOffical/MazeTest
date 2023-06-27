using UnityEngine;
using Zenject;

public class WinZoneTrigger : MonoBehaviour
{
    [SerializeField] NextLeaval _nextLeaval;
    private ClipMusic _clipMusic;
    private Winer _winer;

    [Inject]
    public void Constuct(Winer Win)
    {
        _winer = Win;
    }

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

    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if (other.gameObject.GetComponent<InputeController>())
            {
                _winer.YouWin();
                _clipMusic.PlayClip();
                _nextLeaval.NextLeavals();
               

            }
        }
    }

    
}
