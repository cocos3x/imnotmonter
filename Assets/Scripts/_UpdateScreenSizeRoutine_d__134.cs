using UnityEngine;
private sealed class ProCamera2D.<UpdateScreenSizeRoutine>d__134 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D <>4__this;
    public float duration;
    public float finalSize;
    public Com.LuisPedroFonseca.ProCamera2D.EaseType easeType;
    private float <startSize>5__2;
    private float <newSize>5__3;
    private float <t>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2D.<UpdateScreenSizeRoutine>d__134(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        float val_4;
        float val_5;
        val_3 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        float val_3 = 0.5f;
        val_4 = 0f;
        val_5 = 0f;
        this.<t>5__4 = val_4;
        val_3 = S2 * val_3;
        this.<startSize>5__2 = val_3;
        this.<newSize>5__3 = val_3;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) <= 1)
        {
            goto label_5;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_6;
        }
        
        this.<>4__this._updateScreenSizeCoroutine = 0;
        goto label_7;
        label_5:
        val_4 = 0;
        label_4:
        if((this.<>4__this) == 0)
        {
                val_4 = 1;
        }
        
        float val_4 = this.duration;
        val_4 = (this.<>4__this.<DeltaTime>k__BackingField) / val_4;
        val_4 = (this.<t>5__4) + val_4;
        this.<t>5__4 = val_4;
        float val_1 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_4, end:  null, value:  this.<>4__this.<DeltaTime>k__BackingField, type:  this.<startSize>5__2);
        this.<newSize>5__3 = this.<startSize>5__2;
        if(val_4 != 0)
        {
                0.SetScreenSize(newSize:  val_1);
        }
        else
        {
                this.<>4__this.SetScreenSize(newSize:  val_1);
        }
        
        UnityEngine.YieldInstruction val_2 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_3 = 1;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_6:
        mem[216] = 0;
        label_7:
        if((this.<>4__this.OnUpdateScreenSizeFinished) == 0)
        {
                return (bool)val_3;
        }
        
        this.<>4__this.OnUpdateScreenSizeFinished.Invoke(obj:  1f);
        return (bool)val_3;
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
