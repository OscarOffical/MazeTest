using UnityEngine;

public class MenuCommand : IComand
{
    private GameObject _menu;
    public MenuCommand(GameObject Menu) 
    {
        _menu = Menu;
    }
    public void Execute()
    {
        _menu.SetActive(true);
    }

    public void Undo()
    {
        _menu.SetActive(false);
    }
}
