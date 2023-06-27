 
public class ConcreteCommand : IComand
{
    private InputeController _inputeController;

    public ConcreteCommand(InputeController inputeController)
    {
        _inputeController = inputeController;
    }

    public void Execute()
    {
        _inputeController.enabled = false;
    }

    public  void Undo()
    {
        _inputeController.enabled = true;
    }
}
