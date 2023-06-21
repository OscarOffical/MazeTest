using UnityEngine;

public class MenuHandler: MonoBehaviour
{
    
    [SerializeField] private GameObject _menuLose;
    [SerializeField] private Pause _pause;
    

    public void ContinionGame()
    {
        var ContinueGameObr = new ContinueGame(_menuLose, _pause);
        ContinueGameObr.ContinueGamseMenu();
    }

    public void SettingMenu()
    {
        var MenuObr = new Menu(_menuLose, _pause);
        MenuObr.GameSettingMenu();
    }

   

}
