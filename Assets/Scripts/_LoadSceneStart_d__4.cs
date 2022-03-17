using UnityEngine;
private sealed class SplashSceneManager.<LoadSceneStart>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SplashSceneManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SplashSceneManager.<LoadSceneStart>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSecondsRealtime val_1 = 536896855;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.<>2__current = val_1;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        this.<>1__state = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.ShowBanner(position:  1, bannerPlaceID:  0);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.PlayMusic(trackName:  -1610610003);
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073701127.HasTurnOffInternet()) != false)
        {
                WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_8 = 0;
            -1073700951.ShowPanel();
            return (bool)val_8;
        }
        
        val_8 = 0;
        this.<>4__this.LoadLevelStart();
        return (bool)val_8;
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
