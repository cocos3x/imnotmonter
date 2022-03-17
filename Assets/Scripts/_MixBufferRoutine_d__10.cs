using UnityEngine;
private sealed class AudioManager.<MixBufferRoutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    private float <time>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AudioManager.<MixBufferRoutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        float val_3;
        var val_4;
        var val_5;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            val_3 = 0f;
            this.<time>5__2 = 0f;
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            val_4 = 536883829;
            if(((mem[536884016] & true) == 0) && (mem[536883945] == 0))
        {
                val_4 = 536883829;
        }
        
            val_5 = mem[536883921];
            if(mem[536883945] < 0)
        {
                val_3 = this.<time>5__2;
        }
        else
        {
                if(((mem[536884016] & true) == 0) && (mem[536883945] == 0))
        {
                val_5 = mem[536883921];
        }
        
            val_5.Clear();
            val_3 = 0f;
            this.<time>5__2 = 0f;
        }
        
        }
        
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        uint val_2 = 0;
        val_2 = val_3 + val_2;
        this.<time>5__2 = val_2;
        this.<>2__current = 536888987;
        val_2 = 1;
        this.<>1__state = val_2;
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
