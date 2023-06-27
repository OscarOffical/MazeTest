using TMPro;
using UnityEngine;

public class PercentVolume : MonoBehaviour
{
    [SerializeField] SettingVolume _settingVolume;
    [SerializeField] TMP_Text _percent;
    private float _volume;

    private void Update()
    {
        Percent();
    }
    public void Percent()
    {
        _volume = float.Parse( _settingVolume._volume.ToString("F2")) * 100;
        _percent.text = _volume.ToString() + "%";
    }


}
