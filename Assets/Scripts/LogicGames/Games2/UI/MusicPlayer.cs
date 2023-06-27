using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private AudioSource _audioSource;
    private VolumeTransfer _volumeTransfer;


    private void Awake()
    {
        _volumeTransfer = FindObjectOfType<VolumeTransfer>();

        if (_audioSource == null)
        {

            _audioSource = GetComponent<AudioSource>();
            _audioSource.clip = _audioClip;
            
            _audioSource.Play();

        }
        
    }

    private void Start()
    {
        _audioSource.volume = _volumeTransfer._volumeSound;
    }

}
