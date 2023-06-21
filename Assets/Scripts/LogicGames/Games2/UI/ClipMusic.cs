using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;


  
    public void PlayClip()
    {
           if(_audioSource == null)
           {
                _audioSource =FindObjectOfType<AudioSource>();
           }
            
            _audioSource.PlayOneShot(_audioClip);

        
    }
}
