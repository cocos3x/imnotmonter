using UnityEngine;
private sealed class ProCamera2DTriggerZoom.<OutsideTriggerRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerZoom <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerZoom.<OutsideTriggerRoutine>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        var val_6;
        val_5 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if(0 != 0)
        {
            goto label_4;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        val_6 = this.<>4__this;
        if(R7 != (this.<>4__this))
        {
            goto label_4;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        val_6 = this.<>4__this;
        if((this.<>4__this) > 0)
        {
            goto label_7;
        }
        
        label_4:
        val_5 = 0f;
        this.<>4__this._zoomVelocity = val_5;
        return (bool)val_5;
        label_7:
        if((this.<>4__this.ResetSizeOnExit) == false)
        {
                112 = 100;
        }
        
        this.<>4__this.UpdateScreenSize(smoothness:  System.Math.Abs(this.<>4__this._targetCamSize));
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_4 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        this.<>1__state = 1;
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
