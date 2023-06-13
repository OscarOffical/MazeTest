 
public class ConcreteCommand : IComand
{
    private InputeControler _inputeControler;

    public ConcreteCommand(InputeControler inputeControler)
    {
        _inputeControler = inputeControler;
    }

    public void Execute()
    {
        _inputeControler.enabled = false;
    }

    public  void Undo()
    {
        _inputeControler.enabled = true;
    }
}
