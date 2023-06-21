using UnityEngine;

public abstract class AbstractMenu
{
    protected GameObject _menuCanvas;
    protected Pause _pause;
    protected  IComand _icomand;
   
    public AbstractMenu(GameObject MenuCanvas, Pause pause)
    {
        _menuCanvas = MenuCanvas; _pause = pause; _icomand = new MenuCommand(_menuCanvas);
    }


    public virtual void ContinueGamseMenu() { }

    public  virtual void GameSettingMenu() { }

   
   
}
