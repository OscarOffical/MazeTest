using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    [SerializeField] private MovingLogica _movingLoging;
    [SerializeField] private GameOver _gameOver;
    [SerializeField] private ProzressSystem _progressSystem;
    [SerializeField] private Winer _winer;
    [SerializeField] private InputeControler _inputeControler;
    [SerializeField] private Pause _pause;
    
    
    public override void InstallBindings()
    {
        BindLogicMove();
        BindGameOver();
        BingGold();
        BindWin();
        BindInputeControler();
        BindPause();



    }


    public void BindLogicMove()
    {
        Container
           .Bind<MovingLogica>()
           .FromInstance(_movingLoging)
           .AsSingle()
           .NonLazy();
           
    }

    public void BindGameOver()
    {
        Container
            .Bind<GameOver>()
            .FromInstance(_gameOver)
            .AsSingle()
            .NonLazy();
            

    }
    public void BingGold()
    {
        Container
         .Bind<ProzressSystem>()
         .FromInstance(_progressSystem)
         .AsSingle()
         .NonLazy();
            
    }
    public void BindWin()
    {
        Container
            .Bind<Winer>()
            .FromInstance(_winer)
            .AsSingle()
            .NonLazy();
    }

    public void BindInputeControler()
    {
        Container
            .Bind<InputeControler>()
            .FromInstance(_inputeControler)
            .AsSingle()
            .NonLazy();
    }
    public void BindPause()
    {
        Container
            .Bind<Pause>()
            .FromInstance(_pause)
            .AsSingle()
            .NonLazy();
    }

}