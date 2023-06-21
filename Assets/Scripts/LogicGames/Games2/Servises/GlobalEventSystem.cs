using System;

public static class GlobalEventSystem 
{
    public static Action ManySystem;
    public static Action StapsSystem;
    public static Action GameOver;

    public static void Signature() => ManySystem?.Invoke();
    public static void SignatureStaps() => StapsSystem?.Invoke();
    public static void SignatureGameOver() => GameOver?.Invoke();
}
