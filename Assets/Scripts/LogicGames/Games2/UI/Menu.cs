using UnityEngine;

public class Menu : AbstractMenu
{
    public Menu(GameObject MenuCanvas, Pause pause) : base(MenuCanvas, pause)
    {

    }

    public override void GameSettingMenu()
    {
       
        _icomand.Execute();
        _pause.GamePause();
    }
}
