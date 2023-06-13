using TMPro;
using UnityEngine;

public class StepsVisuaUll : MonoBehaviour
{
    [SerializeField] public int _ammountSteps;
    private TMP_Text _ammountWall;

    private void OnEnable() => GlobalEventSystem.StapsSystem += AmmountSteps;
    private void OnDisable() => GlobalEventSystem.StapsSystem -= AmmountSteps;
   

    void Awake()
    {
        _ammountWall = transform.GetChild(0).GetComponent<TMP_Text>();
        _ammountWall.text = _ammountSteps.ToString();
    }

    public void AmmountSteps()
    {
        _ammountSteps--;
        _ammountWall.text = _ammountSteps.ToString();
        if (_ammountSteps <= 0)
        {
            GlobalEventSystem.SignatureGameOver();
        }
    }
}
