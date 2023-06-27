using UnityEngine;
using UnityEngine.UI;

public class SettingVolume : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private AudioSource _audioSource;
    private float _maxVolume;
    public  float _volume;

    private void Awake()
    {
        if (_maxVolume != 1f)
        {
            _maxVolume = 1f;
        }
        _slider.value = _maxVolume;
    }
    private void Update()
    {
        Volume();
        _volume = _slider.value;
    }



    public void Volume()
    {
        
         _audioSource.volume = _slider.value;
        
        
    }

}
