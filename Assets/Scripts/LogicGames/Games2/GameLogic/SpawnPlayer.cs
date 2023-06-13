using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefabs;
    [SerializeField] private Transform _startPoint;
    private void Awake()
    {
        var Player = Instantiate(_playerPrefabs, _startPoint.position, Quaternion.identity);
    }
}
