using UnityEngine;
private sealed class ProCamera2DRooms.<TestRoomRoutine>d__56 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DRooms <>4__this;
    private UnityEngine.WaitForSeconds <waitForSeconds>5__2;
    private UnityEngine.WaitForSecondsRealtime <waitForSecondsRealtime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DRooms.<TestRoomRoutine>d__56(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        if(((this.<>1__state) - 2) < 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_2 = 536896839;
        val_2 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_2;
        val_7 = 1;
        goto label_12;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_3 = 536896849;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<waitForSeconds>5__2 = val_3;
        UnityEngine.WaitForSecondsRealtime val_4 = 536896855;
        val_4 = new UnityEngine.WaitForSecondsRealtime(time:  null);
        this.<waitForSecondsRealtime>5__3 = val_4;
        label_6:
        if((this.<>4__this.AutomaticRoomActivation) != false)
        {
                this.<>4__this.TestRoom();
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.<>4__this.ProCamera2D;
        if((this.<>4__this) != 0)
        {
                this.<>2__current = this.<waitForSecondsRealtime>5__3;
            val_7 = 2;
        }
        else
        {
                this.<>2__current = this.<waitForSeconds>5__2;
            val_7 = 3;
        }
        
        label_12:
        this.<>1__state = val_7;
        val_6 = 1;
        return (bool)val_6;
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
