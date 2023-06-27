using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other ??= null)
        {
            if (other.gameObject.GetComponent<InputeController>())
            {
                GlobalEventSystem.SignatureGameOver();
            }
        }
    }
}
