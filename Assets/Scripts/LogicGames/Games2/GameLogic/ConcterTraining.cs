using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConcterTraining : ITrainiing
{
    private Image _imageSpiking;
    private Sprite _spriteSpiling;
    private TMP_Text _textPiking;
    private string _text;

    public ConcterTraining(Image ImageSpiking, Sprite SpriteSpiking, TMP_Text TextSpiking, string Text)
    {
        _imageSpiking= ImageSpiking;
        _spriteSpiling= SpriteSpiking;
        _textPiking= TextSpiking;
        _text= Text;
    }
    public void Trainiing()
    {
        _imageSpiking.sprite = _spriteSpiling;
        _textPiking.text = _text;
    }
}
