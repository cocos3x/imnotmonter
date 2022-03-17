using UnityEngine;
private sealed class StickBarrierMoveTrackController.<WaitCanActivated>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public StickBarrierMoveTrackController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StickBarrierMoveTrackController.<WaitCanActivated>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        StickBarrierMoveTrackController val_3;
        val_2 = 0;
        val_3 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if(val_3 == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.isCanActivated = false;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.isCanActivated = true;
        return (bool)val_2;
        label_3:
        mem[40] = 0;
        label_4:
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_3;
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
