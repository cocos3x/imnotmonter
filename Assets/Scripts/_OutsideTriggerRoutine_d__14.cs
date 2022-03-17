using UnityEngine;
private sealed class ProCamera2DTriggerInfluence.<OutsideTriggerRoutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerInfluence.<OutsideTriggerRoutine>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        float val_4;
        int val_13 = 0;
        if(((this.<>1__state) - 1) < 2)
        {
                this.<>1__state = 0;
            if(0 != 0)
        {
                return (bool)val_13;
        }
        
            val_13 = 0;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            float val_13 = val_3;
            var val_14 = val_4;
            val_13 = S18 - val_13;
            val_14 = (this.<>4__this._influence) - val_14;
            val_13 = val_13 * val_13;
            if(0 < 0)
        {
                return (bool)val_13;
        }
        
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.SmoothDamp(current:  new UnityEngine.Vector2() {x = 0.6812859f, y = mem[this.<>4__this._influence + (0)]}, target:  new UnityEngine.Vector2() {x = mem[this.<>4__this._influence + (4)], y = val_4}, currentVelocity: ref  new UnityEngine.Vector2() {x = val_3, y = this.<>4__this._velocity}, smoothTime:  UnityEngine.Time.deltaTime, maxSpeed:  val_5.y, deltaTime:  val_13);
            this.<>4__this._influence = val_4;
            mem2[0] = val_3;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.<>4__this.ProCamera2D;
            this.<>4__this.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = this.<>4__this._influence.x, y = this.<>4__this._influence.y});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = this.<>4__this.ProCamera2D;
            UnityEngine.YieldInstruction val_10 = this.<>4__this.GetYield();
            this.<>2__current = this.<>4__this;
            val_13 = 1;
            this.<>1__state = 2;
            return (bool)val_13;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_12 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_13 = 1;
        this.<>1__state = val_13;
        return (bool)val_13;
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
