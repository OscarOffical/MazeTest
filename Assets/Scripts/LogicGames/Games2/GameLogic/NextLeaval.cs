using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLeaval : MonoBehaviour
{
   private Leaval leaval;

    private void Awake()
    {
        leaval = FindObjectOfType<Leaval>();
    }

    public void NextLeavals()
    {
        var a = SceneManager.GetActiveScene().buildIndex;
        leaval.leavel = a;
    }
}
