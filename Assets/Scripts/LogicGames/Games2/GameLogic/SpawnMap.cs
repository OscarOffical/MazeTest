using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] private GameObject _cubeGreenPrefab;
    [SerializeField] private GameObject _cubeRedPrefab;
    private int AmmountCube = 10;
    void Start()
    {
        for (int positionZ = 0; positionZ <= AmmountCube; positionZ++)
        {
            for (int positionX = 0; positionX <= AmmountCube; positionX++)
            {
                Vector3 Otr = new Vector3(positionX, 0, positionZ);
                if (positionZ == 0 || positionX == AmmountCube || positionZ == AmmountCube || positionZ == positionX) 
                {
                    var CubeRed = Instantiate(_cubeRedPrefab, Otr, Quaternion.identity);
                }
                else
                {
                    var CubeGreen = Instantiate(_cubeGreenPrefab, Otr, Quaternion.identity);
                }



                
            }
        }
    }

    
    void Update()
    {
        
    }
}
