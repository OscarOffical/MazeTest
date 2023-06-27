using UnityEngine;
using Zenject;

public class InputeController : MonoBehaviour
{

    [SerializeField] private MovingLogica _movingLogic;
    [Inject]
    public void Consruct(MovingLogica movingLogica)
    {
        _movingLogic = movingLogica;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _movingLogic.MoveRight();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _movingLogic.MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _movingLogic.MoveUp();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _movingLogic.MoveDown();
        }






    }
}
