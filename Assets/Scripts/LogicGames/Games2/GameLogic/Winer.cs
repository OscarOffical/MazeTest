using UnityEngine;
using Zenject;

public class Winer : MonoBehaviour
{
    [SerializeField] private GameObject MenuWiner;
    private Pause _pause;
    
    

    [Inject]
    public void Constract(Pause pause)
    {
        _pause = pause;
    }
    public void YouWin()
    {
        MenuWiner.SetActive(true);
        _pause.GamePause();
    }

   
   
}
