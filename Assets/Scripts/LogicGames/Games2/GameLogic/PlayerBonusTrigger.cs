using UnityEngine;
using Zenject;

public class PlayerBonusTrigger : MonoBehaviour
{
    private ClipMusic _clipMusic;
    private ProzressSystem _progressSystem;
    
    [Inject]
    public void Constuct(ProzressSystem RrogressSystem)
    {
        _progressSystem= RrogressSystem;
    }

    private void Awake()
    {
        if(_clipMusic == null )
        {
            _clipMusic = GetComponent<ClipMusic>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
            if(other.gameObject.GetComponent<Gold>())
            {
                _progressSystem.Gold();
                _clipMusic.PlayClip();
                Destroy(other.gameObject);
            }
            
        }
    }
}
