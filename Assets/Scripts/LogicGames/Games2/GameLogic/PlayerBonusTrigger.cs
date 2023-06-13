using UnityEngine;
using Zenject;

public class PlayerBonusTrigger : MonoBehaviour
{
    private ProzressSystem _progressSystem;
    [Inject]
    public void Constuct(ProzressSystem RrogressSystem)
    {
        _progressSystem= RrogressSystem;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
            if(other.CompareTag("Gold"))
            {
                _progressSystem.Gold();
                Destroy(other.gameObject);
            }
            
        }
    }
}
