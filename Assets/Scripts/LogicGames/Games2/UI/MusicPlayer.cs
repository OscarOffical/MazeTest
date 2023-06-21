using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private AudioSource _audioSource;


    private void Awake()
    {
       if(_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.clip = _audioClip;
            _audioSource.Play();

        }
        
    }
}
