using UnityEngine;
private sealed class LoadingSceneManager.<LoadAsynchronously>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameTool.LoadingSceneManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingSceneManager.<LoadAsynchronously>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        object val_9;
        var val_10;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 17881032 + (17881032 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                17881032 + (this.<>1__state) << 2 = (17881032 + (this.<>1__state) << 2) & ((17881032 + (this.<>1__state) << 2) << (17881032 + (this.<>1__state) << 2));
            17881032 + (this.<>1__state) << 2 = (17881032 + (this.<>1__state) << 2) & (((R8) << (32-1)) | ((R8) << 1));
            17881032 + (this.<>1__state) << 2 = (17881032 + (this.<>1__state) << 2) & 392445056;
        }
        
            this.<>1__state = 0;
            val_7 = 536889775;
            if(((mem[536889962] & true) == 0) && (mem[536889891] == 0))
        {
                val_7 = 536889775;
        }
        
            UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  mem[536889867] + 4, mode:  0);
            this.<>4__this._asyncOperation = mem[536889867] + 4;
            this.<>4__this + 28.allowSceneActivation = false;
        }
        else
        {
                val_8 = 0;
            return (bool)val_8;
        }
        
        float val_3 = 52.progress;
        if(52 >= 0)
        {
                mem[36] = 1065353216;
            UnityEngine.WaitForSeconds val_4 = 536896849;
            val_9 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  0.9f);
            this.<>2__current = val_9;
            val_10 = 2;
            mem[1152921510024611748] = ;
            val_8 = 1;
            return (bool)val_8;
        }
        
        val_9 = 52;
        float val_6 = val_9.progress;
        mem[36] = val_9;
        this.<>2__current = 0;
        val_8 = 1;
        this.<>1__state = val_8;
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
