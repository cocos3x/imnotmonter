using UnityEngine;
private sealed class API.<CheckFinishData>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public API <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public API.<CheckFinishData>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSecondsRealtime val_1 = 536896855;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.<>2__current = val_1;
            val_2 = 1;
            this.<>1__state = val_2;
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.finishSetData) == true)
        {
                return (bool)val_2;
        }
        
        val_2 = 0;
        this.<>4__this.maxManager.Init(apiInfor:  this.<>4__this.ApiInfor);
        this.<>4__this.finishSetData = true;
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
