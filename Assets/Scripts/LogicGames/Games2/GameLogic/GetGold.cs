using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGold : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
            if (other.CompareTag("Player"))
            {
                GlobalEventSystem.Signature();
                Destroy(gameObject);

            }
        }
    }

   
}
