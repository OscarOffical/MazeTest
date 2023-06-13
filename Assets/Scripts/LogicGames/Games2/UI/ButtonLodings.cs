using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLodings : MonoBehaviour
{
    public void Loding(int Scenes)
    {
        SceneManager.LoadScene(Scenes);
    }
}
