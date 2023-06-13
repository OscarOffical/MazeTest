using UnityEngine;
using Zenject;

public class Pause : MonoBehaviour
{
    [SerializeField] public InputeControler _inputeControler;
    private IComand ConcretCommand;


    [Inject]
    public void Sinstract(InputeControler inputeControler)
    {
        _inputeControler = inputeControler;
    }
    private void Awake()
    {
        ConcretCommand = new ConcreteCommand(_inputeControler);
    }
    public void GamePause()
    {
        
        ConcretCommand.Execute();
    }

    public void Play()
    {
        var play = new ConcreteCommand(_inputeControler);
        play.Undo();
    }
}
