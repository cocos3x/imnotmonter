using UnityEngine;
private sealed class ProCamera2DLetterbox.<TweenToRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DLetterbox <>4__this;
    public float duration;
    public float targetAmount;
    private float <initialAmount>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DLetterbox.<TweenToRoutine>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        float val_6;
        int val_7;
        var val_8;
        val_5 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        val_6 = 0f;
        this.<initialAmount>5__2 = this.<>4__this.Amount;
        this.<t>5__3 = 0f;
        goto label_7;
        label_1:
        val_7 = 0;
        goto label_9;
        label_2:
        this.<>1__state = 0;
        if((this.<>1__state) <= 1)
        {
            goto label_7;
        }
        
        this.<>4__this.Amount = this.targetAmount;
        this.<>2__current = 0;
        val_5 = 1;
        val_7 = 2;
        goto label_9;
        label_7:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
        if(0 != 0)
        {
                val_8 = 0;
            float val_2 = UnityEngine.Time.unscaledDeltaTime;
        }
        else
        {
                val_8 = 0;
            float val_3 = UnityEngine.Time.deltaTime;
        }
        
        uint val_5 = 0;
        val_5 = val_5 / this.duration;
        val_7 = 1;
        val_5 = val_6 + val_5;
        this.<t>5__3 = val_5;
        float val_4 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_5, end:  null, value:  this.duration, type:  this.<initialAmount>5__2);
        this.<>4__this.Amount = this.<initialAmount>5__2;
        this.<>2__current = 0;
        val_5 = 1;
        label_9:
        this.<>1__state = val_7;
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
