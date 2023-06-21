using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLodings : MonoBehaviour
{
    public int _sense;
    public void Loding(int Scenes)
    {
        
      SceneManager.LoadScene(Scenes);
        
    }
}
