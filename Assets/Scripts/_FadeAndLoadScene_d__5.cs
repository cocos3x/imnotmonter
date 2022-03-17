using UnityEngine;
private sealed class SceneFader.<FadeAndLoadScene>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SceneFader <>4__this;
    public SceneFader.FadeDirection fadeDirection;
    public string sceneToLoad;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SceneFader.<FadeAndLoadScene>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            System.Collections.IEnumerator val_1 = this.<>4__this.Fade(fadeDirection:  this.fadeDirection);
            this.<>2__current = this.<>4__this;
            val_2 = 1;
            this.<>1__state = val_2;
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        val_2 = 0;
        GameTool.EventDispatcher.ClearAllListener();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.sceneToLoad);
        return (bool)val_2;
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
