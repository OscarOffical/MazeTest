using UnityEngine;
using Zenject;

public class InputeControler : MonoBehaviour
{

    [SerializeField] private MovingLogica _movingLogic;
    [SerializeField] private float _speed = 1;
    [SerializeField] Rigidbody _rigidbody;
    [Inject]
    public void Consruct(MovingLogica movingLogica)
    {
        _movingLogic = movingLogica;
    }
    public void Awake()
    {
        _rigidbody= GetComponent<Rigidbody>();
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
