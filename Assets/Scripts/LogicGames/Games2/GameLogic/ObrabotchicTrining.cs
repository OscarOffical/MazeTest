using UnityEngine;
using Zenject;

public class ObrabotchicTrining : MonoBehaviour
{
    [SerializeField] private Training _training;
    [SerializeField] private int _progressTrining = 0;
    private Pause _pause;
    
    [Inject]
    public void Constract(Pause pause)
    {
        _pause= pause;
    }

    private void Awake()
    {
        if (_progressTrining != 0)
        {
            _progressTrining = 0;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _progressTrining++;
        }
        OpitetionTraining();


    }

    public void OpitetionTraining()
    {
        _pause.GamePause();
        switch (_progressTrining) 
        {
            case 0:
                _training.TriningOne();
                break;
            case 1:
                _training.TriningTwo(); 
                break;
            case 2:
                _training.TriningThree();
                break;
            case 3:
                _training.TriningFour();
                break;
            case 4:
                _pause.Play();
                _training.DestroyTraining();
                break;
        }



    }

}
