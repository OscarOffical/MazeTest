using TMPro;
using UnityEngine;

public class ProzressSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text _goldText;
    [SerializeField] private int AmmountDropGold;
    private int _gold;


    private void OnEnable() => GlobalEventSystem.ManySystem += Gold;
    private void OnDisable() => GlobalEventSystem.ManySystem -= Gold;
  

    void Start()
    {
        if(_gold <= 0)
        {
            _gold = 0;
        }

        _goldText = transform.GetChild(0).GetComponent<TMP_Text>();
        _goldText.text = _gold.ToString();

    }

    public void Gold()
    {
        _gold += AmmountDropGold;
        _goldText.text = _gold.ToString();
    }

   
}
