using UnityEngine;
using Zenject;

public class Pause : MonoBehaviour
{
    [SerializeField] private InputeController _inputeController;
    private IComand ConcretCommand;

    [Inject]
    public void Sinstract(InputeController inputeController)
    {
        _inputeController = inputeController;
    }
    private void Awake()
    {
        ConcretCommand = new ConcreteCommand(_inputeController);
    }
    public void GamePause()
    {
        
        ConcretCommand.Execute();
    }

    public void Play()
    {
       ConcretCommand.Undo();
    }
}
