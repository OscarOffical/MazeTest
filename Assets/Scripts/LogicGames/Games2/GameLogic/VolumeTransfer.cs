using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VolumeTransfer : MonoBehaviour
{
   [SerializeField] private SettingVolume _soundSetting;
   [SerializeField] private SettingVolume _melodiaSetting;

    public float _volumeSound;
    private float _volumeMelodia;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

       
        
    }
    private void Update()
    {
        _volumeMelodia = _melodiaSetting._volume;
        _volumeSound = _soundSetting._volume;
        

    }
}
