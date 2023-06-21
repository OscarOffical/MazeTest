using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Training : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite[] _sprite;
    [SerializeField] private TMP_Text _tmp_text;
    private string[] _text = new string[4];
    private ITrainiing _iTraining;
   



    public void TriningOne()
    {  
        _text[0] = "������, � �����, ���� ����� ��������� ��� ������ WASD";
        _iTraining = new ConcterTraining(_image, _sprite[0], _tmp_text, _text[0]);
        _iTraining.Trainiing();
    }

    public void TriningTwo()
    {   
        _text[1] = "P-p-p, � �� ���� ����� �� ������������, �� ����� ������������. ";
        _iTraining = new ConcterTraining(_image, _sprite[1], _tmp_text, _text[1]);
        _iTraining.Trainiing();
    }
    public void TriningThree()
    {   
        _text[2] = "������� ��� ����� �������� �������. ";
        _iTraining = new ConcterTraining(_image, _sprite[2], _tmp_text, _text[2]);
        _iTraining.Trainiing();
    }

    public void TriningFour()
    {
        _text[3] = "�������� �� ���� ����� ������ �������. ";
        _iTraining = new ConcterTraining(_image, _sprite[3], _tmp_text, _text[3]);
        
        _iTraining.Trainiing();
    }


    public void DestroyTraining()
    {
        Destroy(gameObject);
        
    }
}
