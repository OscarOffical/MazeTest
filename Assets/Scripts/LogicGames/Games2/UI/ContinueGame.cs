using UnityEngine;

public class ContinueGame :  AbstractMenu
{

    public ContinueGame(GameObject MenuCanvas, Pause pause) : base(MenuCanvas, pause) { }
  

    public override void ContinueGamseMenu() 
    {
        _icomand.Undo();
        _pause.Play();

    }

   
}
