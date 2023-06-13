using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private Pause pause;
    
    private void OnEnable() => GlobalEventSystem.GameOver += LoseGame;
    private void OnDisable() => GlobalEventSystem.GameOver -= LoseGame;
   

    public void LoseGame()
    {

        Menu.SetActive(true);
        pause.GamePause();
        
    }
}
