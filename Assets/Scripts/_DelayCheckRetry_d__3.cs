using UnityEngine;
private sealed class SplashSceneManager.<DelayCheckRetry>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SplashSceneManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SplashSceneManager.<DelayCheckRetry>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            val_5 = 1;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073701127.HasTurnOffInternet()) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_5 = 0;
            -1073700951.ShowPanel();
            return (bool)val_5;
        }
        
        val_5 = 0;
        this.<>4__this.LoadLevelStart();
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
