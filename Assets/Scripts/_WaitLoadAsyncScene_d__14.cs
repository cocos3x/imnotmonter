using UnityEngine;
private sealed class SceneLoadManager.<WaitLoadAsyncScene>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string name;
    public SceneLoadManager <>4__this;
    private UnityEngine.AsyncOperation <asyncLoad>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SceneLoadManager.<WaitLoadAsyncScene>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        UnityEngine.AsyncOperation val_11;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_10 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        string val_1 = -1610604751(-1610604751) + this.name + -1610612353(-1610612353);
        UnityEngine.Debug.Log(message:  -1610604751);
        GameTool.EventDispatcher.ClearAllListener();
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700871.StartFade(action:  0);
        }
        
        UnityEngine.WaitForSecondsRealtime val_4 = 536896855;
        val_4 = new UnityEngine.WaitForSecondsRealtime(time:  null);
        this.<>2__current = val_4;
        val_10 = 1;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        val_11 = this.<asyncLoad>5__2;
        this.<>1__state = 0;
        goto label_11;
        label_2:
        this.<>1__state = 0;
        AFramework.UI.CanvasManager.ClearAllUI();
        UnityEngine.AsyncOperation val_5 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  this.name);
        val_11 = this;
        this.<asyncLoad>5__2 = this.name;
        label_11:
        if((this.<asyncLoad>5__2.isDone) == false)
        {
            goto label_17;
        }
        
        if((this.<>4__this.isLoading) == false)
        {
            goto label_19;
        }
        
        this.<>4__this.isLoading = false;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700871.EndFade(action:  0);
        }
        
        val_10 = 0;
        string val_9 = -1610604751(-1610604751) + this.name + -1610612355(-1610612355);
        UnityEngine.Debug.Log(message:  -1610604751);
        return (bool)val_10;
        label_17:
        this.<>2__current = 0;
        val_10 = 1;
        this.<>1__state = 2;
        return (bool)val_10;
        label_19:
        val_10 = 0;
        return (bool)val_10;
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
