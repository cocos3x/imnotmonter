using UnityEngine;
private sealed class ProCamera2DShake.<ConstantShakeRoutine>d__47 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake <>4__this;
    public float intensity;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DShake.<ConstantShakeRoutine>d__47(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        var val_5;
        if((this.<>1__state) >= 2)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._isConstantShaking) == false)
        {
                return (bool)0;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        if((this.<>4__this) > 0)
        {
                UnityEngine.Vector3 val_2 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetVectorsSum(input:  1042072324);
            var val_14 = val_3;
            var val_15 = val_4;
            float val_16 = (float)val_2.x;
            val_14 = val_14 / val_16;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.<>4__this.ProCamera2D;
            val_15 = val_15 / val_16;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.<>4__this.ProCamera2D;
            val_16 = val_5 / val_16;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = this.<>4__this.ProCamera2D;
            float val_11 = Com.LuisPedroFonseca.ProCamera2D.Utils.SmoothApproach(pastPosition:  Com.LuisPedroFonseca.ProCamera2D.Utils.SmoothApproach(pastPosition:  Com.LuisPedroFonseca.ProCamera2D.Utils.SmoothApproach(pastPosition:  val_2.x, pastTargetPosition:  val_2.y, targetPosition:  val_2.z, speed:  null, deltaTime:  null), pastTargetPosition:  val_2.y, targetPosition:  val_2.z, speed:  null, deltaTime:  null), pastTargetPosition:  val_2.y, targetPosition:  val_2.z, speed:  null, deltaTime:  null);
            this.<>4__this._constantShakePosition = this.<>4__this._constantShakePosition;
            mem2[0] = this.intensity;
            mem2[0] = this.intensity;
            this.<>4__this._influences.Add(item:  new UnityEngine.Vector3() {x = this.<>4__this._constantShakePosition, y = this.intensity, z = this.intensity});
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_13 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        0 = 1;
        this.<>1__state = 0;
        return (bool)0;
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
