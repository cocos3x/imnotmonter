using UnityEngine;
private sealed class ProCamera2DParallax.<Animate>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DParallax <>4__this;
    public float duration;
    public bool value;
    public Com.LuisPedroFonseca.ProCamera2D.EaseType easeType;
    private float[] <currentSpeeds>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DParallax.<Animate>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        System.Single[] val_6;
        var val_7;
        float val_8;
        var val_9;
        var val_10;
        var val_11;
        val_5 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        val_6 = this;
        this.<currentSpeeds>5__2 = 536882357;
        val_7 = 4;
        goto label_5;
        label_12:
        if(1152921509923942896 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem[536882373] = static_value_0028000F;
        val_7 = 5;
        label_5:
        if((val_7 - 4) < mem[536882369])
        {
            goto label_12;
        }
        
        val_8 = 0f;
        this.<t>5__3 = 0f;
        goto label_15;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) > 1)
        {
                return (bool)val_5;
        }
        
        label_15:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        val_9 = 16;
        float val_6 = this.duration;
        val_10 = 0;
        val_6 = S2 / val_6;
        val_6 = (this.<t>5__3) + val_6;
        this.<t>5__3 = val_6;
        goto label_17;
        label_29:
        if((this.<>4__this) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = this.<currentSpeeds>5__2;
        if(this.value != false)
        {
                float val_7 = this.<>4__this._initialSpeeds[0];
            val_11 = 791523184;
        }
        else
        {
                val_11 = 791523184;
        }
        
        float val_3 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_6, end:  null, value:  null, type:  791523184);
        val_9 = 20;
        val_10 = 1;
        label_17:
        if(val_10 < 1)
        {
            goto label_29;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_5 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_5 = 1;
        this.<>1__state = val_5;
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
