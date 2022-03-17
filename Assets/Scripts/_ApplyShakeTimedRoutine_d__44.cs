using UnityEngine;
private sealed class ProCamera2DShake.<ApplyShakeTimedRoutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake <>4__this;
    public bool ignoreTimeScale;
    public float duration;
    public UnityEngine.Vector2 shake;
    public UnityEngine.Quaternion rotation;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DShake.<ApplyShakeTimedRoutine>d__44(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        float val_6;
        float val_7;
        int val_10;
        var val_11;
        System.Collections.Generic.List<UnityEngine.Vector3> val_12;
        val_10 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this._rotationTime = 0f;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        goto label_5;
        label_3:
        mem[128] = 0;
        label_4:
        this.<>4__this._rotationVelocity = 0f;
        label_5:
        if((this.<>4__this) <= 0)
        {
                return (bool)val_10;
        }
        
        if(this.ignoreTimeScale != false)
        {
                float val_1 = UnityEngine.Time.unscaledDeltaTime;
            val_11 = 0;
        }
        else
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        }
        
        float val_3 = this.duration - S0;
        this.duration = val_3;
        if((this.<>4__this) != 0)
        {
                val_12 = this.<>4__this._shakePositions;
        }
        else
        {
                val_12 = 0;
        }
        
        UnityEngine.Vector3 val_4 = Invoke(arg1:  val_3, arg2:  null);
        val_12.Add(item:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_9 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_10 = 1;
        this.<>1__state = val_10;
        return (bool)val_10;
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
