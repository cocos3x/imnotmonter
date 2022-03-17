using UnityEngine;
private sealed class ProCamera2DShake.<StopConstantShakeRoutine>d__45 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake <>4__this;
    public float duration;
    private UnityEngine.Vector3 <velocity>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DShake.<StopConstantShakeRoutine>d__45(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Vector3 val_6;
        float val_7;
        float val_8;
        int val_11;
        System.Collections.Generic.List<UnityEngine.Vector3> val_12;
        UnityEngine.Vector3 val_13;
        float val_14;
        System.Collections.Generic.List<UnityEngine.Vector3> val_15;
        val_11 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
            this.<>1__state = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_12 = this.<>4__this._influences;
            val_12.Clear();
        }
        else
        {
                this.<>1__state = 0;
        }
        
        if((this.<>1__state) < 1)
        {
                return (bool)val_11;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        this.duration = this.duration - S0;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = 0.1288491f, y = mem[this.<>4__this._constantShakePosition + (0)], z = mem[this.<>4__this._constantShakePosition + (4)]}, target:  new UnityEngine.Vector3() {x = mem[this.<>4__this._constantShakePosition + (8)]}, currentVelocity: ref  new UnityEngine.Vector3() {y = this.<velocity>5__2, z = this.duration}, smoothTime:  this.duration, maxSpeed:  val_4.y);
        val_13 = val_6;
        val_12 = val_7;
        val_14 = val_8;
        if((this.<>4__this) != 0)
        {
                val_15 = this.<>4__this._influences;
            this.<>4__this._constantShakePosition = val_13;
            mem2[0] = val_12;
            mem2[0] = val_14;
        }
        else
        {
                this.<>4__this._constantShakePosition = val_13;
            mem2[0] = val_12;
            mem2[0] = val_14;
            val_15 = 1476352;
            val_13 = this.<>4__this._constantShakePosition;
        }
        
        val_15.Add(item:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_14});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_10 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_11 = 1;
        this.<>1__state = val_11;
        return (bool)val_11;
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
